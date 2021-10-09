using LineChartDemo.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LineChartDemo.Controllers
{
    public class PieChartController : Controller
    {
        private readonly ApplicationDataContext _db;

        public PieChartController(ApplicationDataContext db)
        {
            _db = db;
        }



        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetData()
        {

            int male = _db.Peopels.Where(m => m.Gender == "Male").Count();
            int female = _db.Peopels.Where(m => m.Gender == "Female").Count();
            Data data = new Data();
            data.Male = male;
            data.Female = female;

            return Json(data);
        }

        public class Data {
            public int Male { get; set; }
            public int Female { get; set; }

        }




        public IActionResult BarChartData()
        {
            return View();
        }
    }
}
