using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPP.Controllers
{
    
    public class HomeController :Controller
    {
        
        public IActionResult Index( int a)
        {
            ViewData["Name"] = "Vetendas";
            ViewData["Surname"] = "Aliyev";

            ViewBag.Name1 = "Vetendas";
            ViewBag.Surname1 = "Veliyev";

            TempData["String"] = "Butun Huqulari qorunur";
                return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
