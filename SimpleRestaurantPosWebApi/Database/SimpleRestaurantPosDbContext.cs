using Microsoft.EntityFrameworkCore;
using SimpleRestaurantPosWebApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRestaurantPosWebApi.Database
{
    public class SimpleRestaurantPosDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Menu> Menus { get; set; }

        public SimpleRestaurantPosDbContext(DbContextOptions<SimpleRestaurantPosDbContext> dbContext) : base(dbContext) { }
    }
}
