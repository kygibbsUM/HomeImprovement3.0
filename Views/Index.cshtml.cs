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
    public class IndexModel : PageModel
    {
        private readonly HomeImprovement3._0.Models.DataContext _context;

        public IndexModel(HomeImprovement3._0.Models.DataContext context)
        {
            _context = context;
        }

        public IList<Services> Services { get;set; }

        public async Task OnGetAsync()
        {
            Services = await _context.Services.ToListAsync();
        }
    }
}
