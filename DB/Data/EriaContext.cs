using eria_back.DB.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eria_back.DB.Data
{
    public class EriaContext:DbContext
    {
        public EriaContext(DbContextOptions<EriaContext> options):base(options)
        {
        }

        public DbSet<CompanyEvent> CompanyEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyEvent>().ToTable("CompanyEvents");
        }
    }
}
