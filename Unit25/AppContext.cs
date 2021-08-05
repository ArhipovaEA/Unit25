using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unit25
{
    public class AppContext : DbContext
    {
        // Объекты таблицы Users
        public DbSet<User> Users{ get; set; }

        public DbSet<Book> Books { get; set; }

        public AppContext()
        {
            Database.EnsureCreated();
            Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-QRUSR96\SQLEXPRESS;Database=EF;Trusted_Connection=True;");
        }
    }
}
