using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Final.Controllers
{
    public class CuentaController : Controller
    {
        public IActionResult Join()
        {
            return View();
        }

        public IActionResult Login()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Registro()
        {
            ViewData["Message"] = "";

            return View();
        }
    }
}