using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LineChartDemo.Models
{
    public class WeaklySales
    {
        public int Id { get; set; }

        public virtual Products Products { get; set; }

        public double Quantiy { get; set; }

        public double Price { get; set; }
    }
}
