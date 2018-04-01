using SimpleRestaurantPosWebApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRestaurantPosWebApi.Database
{
    public static class DbHelper
    {
        public static void InitializeDatabase(SimpleRestaurantPosDbContext context)
        {
            if (context.Menus.Any())
            {
                return;     // Db has been initialized
            }

            //Start populating menus
            var pizza = new Menu
            {
                Description = "Pizza",
                Price = 10
            };

            var spaghetti = new Menu
            {
                Description = "Spaghetti",
                Price = 15
            };

            var burger = new Menu
            {
                Description = "Burger",
                Price = 21
            };

            var appleJuice = new Menu
            {
                Description = "Apple Juice",
                Price = 6
            };

            var water = new Menu
            {
                Description = "Plain Water",
                Price = 3
            };

            // Start populating tables
            var table1 = new Table { Description = "Table 1" };
            var table2 = new Table { Description = "Table 2" };
            var table3 = new Table { Description = "Table 3" };

            //var order1 = new Order
            //{

            //}

            context.Menus.Add(pizza);
            context.Menus.Add(spaghetti);
            context.Menus.Add(burger);
            context.Menus.Add(appleJuice);
            context.Menus.Add(water);

            context.Tables.Add(table1);
            context.Tables.Add(table2);
            context.Tables.Add(table3);

            context.SaveChanges();
        }
    }
}
