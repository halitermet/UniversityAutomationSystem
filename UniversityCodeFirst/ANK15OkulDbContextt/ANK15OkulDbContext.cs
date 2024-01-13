using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityCodeFirst.Concrete;


namespace UniversityCodeFirst.ANK15OkulDbContextt
{
    public class ANK15OkulDbContext:DbContext
    { 
         public DbSet <Diploma>Diplomalar { get; set; }
         public DbSet<OgrenciForm> Ogrenciler { get; set; }
         public DbSet<Danisman>Danısmanlar { get; set; }
         public DbSet<DersForm>Dersler { get; set; }

         public DbSet<OgrenciDersForm> OgrenciDersLer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HALITERMET;Trusted_Connection=true;database=ANK15OkulDb;TrustServerCertificate=True");
        }
      
    }
    
    
}
