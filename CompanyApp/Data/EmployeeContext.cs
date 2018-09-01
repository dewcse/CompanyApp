using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CompanyApp.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext (DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<CompanyApp.Models.Employee> Employee { get; set; }
        public DbSet<CompanyApp.Models.Manager> Manager { get; set; }
    }
}
