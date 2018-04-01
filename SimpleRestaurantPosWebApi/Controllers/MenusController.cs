using Microsoft.AspNetCore.Mvc;
using SimpleRestaurantPosWebApi.Database;
using SimpleRestaurantPosWebApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRestaurantPosWebApi.Controllers
{
    [Route("api/[controller]")]
    public class MenusController : Controller
    {
        // GET api/menus
        [HttpGet]
        public IEnumerable<Menu> Get()
        {
            return context.Menus.ToList();
        }

        // GET api/menus
        [Route("{id}")]
        [HttpGet]
        public Menu GetMenusById(int id)
        {
            var menus = context.Menus.ToList();

            return menus.FirstOrDefault(menu => menu.MenuId == id);
        }

        public MenusController(SimpleRestaurantPosDbContext dbContext)
        {
            context = dbContext;
        }

        SimpleRestaurantPosDbContext context;
    }
}
