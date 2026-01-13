using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proj_bazy.Data;
using Proj_bazy.Models;

namespace Proj_bazy.Controllers
{
    public class HotelRoomController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HotelRoomController(ApplicationDbContext context) => _context = context;

        // 1. NAPRAWA LISTY: Pobieranie danych z bazy
        public async Task<IActionResult> Index()
        {
            var rooms = await _context.HotelRooms.Include(h => h.RoomType).ToListAsync();
            return View(rooms);
        }

        public IActionResult Create()
        {
            ViewBag.RoomTypeId = new SelectList(_context.RoomTypes, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Number,RoomTypeId")] HotelRoom hotelRoom)
        {
            var exists = await _context.HotelRooms.AnyAsync(r => r.Number == hotelRoom.Number);

            if (exists)
            {
                ModelState.AddModelError("Number", "Pokój o tym numerze już istnieje w systemie!");
            }

            if (ModelState.IsValid)
            {
                _context.Add(hotelRoom);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.RoomTypeId = new SelectList(_context.RoomTypes, "Id", "Name", hotelRoom.RoomTypeId);
            return View(hotelRoom);
        }
    }
}