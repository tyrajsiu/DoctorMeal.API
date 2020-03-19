using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DoctorMeal.Models;
using DoctorMeal.Data;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Newtonsoft.Json;
using DoctorMeal.Data.Entities;

namespace DoctorMeal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //using (StreamReader r = new StreamReader("C:/Projects/PosilekDlaLekarza.API/restauratnsData.json"))
            //{
            //    string json = r.ReadToEnd();
            //    List<Restaurant> items = JsonConvert.DeserializeObject<List<Restaurant>>(json);
            //    _context.Restaurant.AddRange(items);
            //    _context.SaveChanges();
            //}

            if (User.Identity.IsAuthenticated)
            {
                return View(await _context.WaitingToConfirmRestaurant.ToListAsync());
            }
            else
            {
                return LocalRedirect("/Identity/Account/Login");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
