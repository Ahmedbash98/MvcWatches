using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcWatches.Models;

namespace MvcWatches.Data
{
    public class MvcWatchesContext : DbContext
    {
        public MvcWatchesContext (DbContextOptions<MvcWatchesContext> options)
            : base(options)
        {
        }

        public DbSet<Watch> Watch { get; set; }
    }
}
