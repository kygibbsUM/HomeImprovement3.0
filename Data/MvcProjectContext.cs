using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HomeImprovement3._0.Models;

namespace HomeImprovement3._0.Data
{
    public class MvcProjectContext : DbContext
    {
        public MvcProjectContext(DbContextOptions<MvcProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Project { get; set; }
    }
}
