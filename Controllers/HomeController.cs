﻿using House_Renting_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace House_Renting_System.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var model = new IndexViewModel();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}