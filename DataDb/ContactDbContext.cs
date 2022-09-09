using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataDb
{
   public class ContactDbContext : DbContext
    {
        


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options)
            {
                //base.OnConfiguring(optionsBuilder);
                //optionsBuilder.UseNpgsql("Server=10.0.90.13; Database=HotelDb;user id=postgres;Password=profen2016;");

            }
            public DbSet<Contacting> Contacts { get; set; }
        }
}
