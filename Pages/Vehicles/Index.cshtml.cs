using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using autoTrader.Models;

namespace autoTrader.Pages.Vehicles
{
    public class IndexModel : PageModel
    {
        private readonly autoTrader.Models.VehicleContext _context;

        public IndexModel(autoTrader.Models.VehicleContext context)
        {
            _context = context;
        }

        public IList<Vehicle> Vehicle { get;set; }

        public async Task OnGetAsync(string searchString)
        {
			var vehicles = from v in _context.Vehicle
						   select v;

			if(!String.IsNullOrEmpty(searchString))
			{
				vehicles = vehicles.Where(v => v.make.Contains(searchString));
			}

            Vehicle = await _context.Vehicle.ToListAsync();
        }
    }
}
