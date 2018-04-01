using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRestaurantPosWebApi.Domain
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
