using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proj_bazy.Data;
using Proj_bazy.Models;

namespace Proj_bazy.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ReservationsApiController(ApplicationDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reservation>>> Get() => await _context.Reservations.ToListAsync();
    }
}