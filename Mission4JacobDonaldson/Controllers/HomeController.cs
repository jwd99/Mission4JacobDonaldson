using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4JacobDonaldson.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4JacobDonaldson.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieFormContext _contexter { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieFormContext saveValue)
        {
            _logger = logger;
            //contexter is used to help in saving to the database
            _contexter = saveValue;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult My_Podcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(FormResponse Response)
        {
            //If the form model data is valid then add and save changes to the database
            if (ModelState.IsValid)
            {
                _contexter.Add(Response);
                //adds response and then saves it
                _contexter.SaveChanges();
                return View("Confirmation", Response);
            }
            //If the form model data is not valid then return the view and show validation information.
            else
            {
                return View();
            }
            
        }

    }
}
