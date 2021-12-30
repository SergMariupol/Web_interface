using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data.Interfaces;
using Web_interface.Data.Models;
using Web_interface.ViewModels;

namespace Web_interface.Controllers
{
    public class OrderListController : Controller
    {
        private readonly IAllOrders _allOrders;

        public OrderListController(IAllOrders allOrders)
        {
            _allOrders = allOrders;
        }


        public IActionResult ReadOrder()
        {
           
            IEnumerable<Order> Order;

            IEnumerable<OrderDetail> OrderDetail;

            ViewBag.Title = "Заказы";





            Order = _allOrders.OrderList;
            OrderDetail = _allOrders.OrderDetailList;

            OrderListViewModel objOrderList = new OrderListViewModel();

            objOrderList.OrderList = Order;
            objOrderList.OrderDetailList = OrderDetail; 







            return View(objOrderList);


        }
    }
}
