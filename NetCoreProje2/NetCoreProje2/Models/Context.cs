
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreProje2.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-92H2T3D;database=Birim3DB;Integrated security=true;");
        }
        public DbSet<Birim> Birims { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet <Admin> Admins { get; set; }
    }
}
