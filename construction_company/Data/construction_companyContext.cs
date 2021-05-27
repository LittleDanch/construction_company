using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using construction_company.Models;

namespace construction_company.Data
{
    public class construction_companyContext : DbContext
    {
        public construction_companyContext (DbContextOptions<construction_companyContext> options)
            : base(options)
        {
        }

        public DbSet<construction_company.Models.Staff> Staff { get; set; }

        public DbSet<construction_company.Models.Brigades> Brigades { get; set; }

        public DbSet<construction_company.Models.Customers> Customers { get; set; }

        public DbSet<construction_company.Models.Material> Material { get; set; }

        public DbSet<construction_company.Models.Orders> Orders { get; set; }

        public DbSet<construction_company.Models.position> position { get; set; }

        public DbSet<construction_company.Models.TypesOfWork> TypesOfWork { get; set; }
    }
}
