﻿using Microsoft.AspNetCore.Mvc;

namespace R54_M10_Class_09_Work_01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
