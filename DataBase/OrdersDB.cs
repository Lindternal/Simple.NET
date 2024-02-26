using Microsoft.EntityFrameworkCore;
using Simple.NET.DataBase.Models;

namespace Simple.NET.DataBase
{
    public class OrdersDB : DbContext
    {
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Prices> Prices { get; set; }
        public DbSet<Tasks> Tasks { get; set; }

        public OrdersDB() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Sata Surce=db.sqlite");
            }
        }
    }
}
