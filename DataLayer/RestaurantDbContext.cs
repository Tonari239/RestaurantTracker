using Microsoft.EntityFrameworkCore;
using RestaurantTracker.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTracker.DataLayer
{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog=RestaurantDB ; Integrated Security=true");
            optionsBuilder.UseLazyLoadingProxies();
        }

    }
}
