using Microsoft.AspNetCore.Mvc;
using Proj_bazy.Models;

namespace Proj_bazy.Controllers
{
    public class DaneController : Controller
    {
        [HttpGet]
        public IActionResult Form() => View();

        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid) return View("Wynik", dane);
            return View();
        }
    }
}