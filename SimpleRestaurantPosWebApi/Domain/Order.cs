using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRestaurantPosWebApi.Domain
{
    public class Order
    {
        public Order()
        {
            Menus = new List<Menu>();
        }

        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }
        public IList<Menu> Menus { get; set; }
        public Table Table { get; set; }
        public int TableId { get; set; }

        public enum OrderStatus
        {
            Open,
            Paid
        }
    }
}
