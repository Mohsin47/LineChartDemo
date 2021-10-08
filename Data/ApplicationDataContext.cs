using LineChartDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LineChartDemo.Data
{
    public class ApplicationDataContext:DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options)
           : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<WeaklySales> WeaklySales { get; set; }
        public DbSet<Peopels> Peopels { get; set; }
    }
}
