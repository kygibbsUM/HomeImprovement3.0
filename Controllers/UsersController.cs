using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HomeImprovement3._0.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index(int ID = -1) //If this shows -1 on the site that means there was no ID received - KG
        {
            ViewData["Message"] = "Displaying Projects for User " + ID;
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome()
        {
            return View();
        }
    }
}