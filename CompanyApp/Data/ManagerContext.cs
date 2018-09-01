using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CompanyApp.Models
{
    public class ManagerContext : DbContext
    {
        public ManagerContext (DbContextOptions<ManagerContext> options)
            : base(options)
        {
        }

        public DbSet<CompanyApp.Models.Manager> Manager { get; set; }
    }
}
