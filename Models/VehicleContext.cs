using System;
using Microsoft.EntityFrameworkCore;

namespace autoTrader.Models
{
    public class VehicleContext: DbContext
    {
        public VehicleContext(DbContextOptions <VehicleContext> options) : base(options)
        {
        }

        public DbSet<Vehicle> Vehicle { get; set; }
    }
}
