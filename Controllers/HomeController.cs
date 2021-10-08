using LineChartDemo.Data;
using LineChartDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LineChartDemo.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDataContext _db;

        public HomeController(ApplicationDataContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetData()
        {

            var query = _db.WeaklySales.Include(m => m.Products)
                .GroupBy(m => m.Products.Name)
                .Select(m => new { name = m.Key, count = m.Sum(w => w.Quantiy) }).ToList();
            return Json(query);
        }
       
        
    }
}
