using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Proj_bazy.Data;
using Proj_bazy.Models;

namespace Proj_bazy.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservationController(ApplicationDbContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var reservations = await _context.Reservations
                .Include(r => r.HotelRoom)
                .Where(r => r.UserId == userId)
                .ToListAsync();

            return View(reservations);
        }

        public IActionResult Create()
        {
            ViewBag.HotelRoomId = new SelectList(_context.HotelRooms, "Id", "Number");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Reservation reservation)
        {
            reservation.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.HotelRoomId = new SelectList(_context.HotelRooms, "Id", "Number", reservation.HotelRoomId);
            return View(reservation);
        }
    }
}