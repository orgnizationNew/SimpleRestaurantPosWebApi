using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRestaurantPosWebApi.Domain
{
    public class Table
    {
        public int TableId { get; set; }
        public string Description { get; set; }
        public Order Order { get; set; }
    }
}
