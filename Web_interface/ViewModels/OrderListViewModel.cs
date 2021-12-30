using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data.Models;

namespace Web_interface.ViewModels
{
    public class OrderListViewModel
    {
        public IEnumerable<Order> OrderList { get; set; }
        public IEnumerable<OrderDetail> OrderDetailList { get; set; }
    }
}
