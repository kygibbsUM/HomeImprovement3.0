using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HomeImprovement3._0.Models;

namespace HomeImprovement3._0.Views
{
    public class DetailsModel : PageModel
    {
        private readonly HomeImprovement3._0.Models.DataContext _context;

        public DetailsModel(HomeImprovement3._0.Models.DataContext context)
        {
            _context = context;
        }

        public Services Services { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Services = await _context.Services.FirstOrDefaultAsync(m => m.ID == id);

            if (Services == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
