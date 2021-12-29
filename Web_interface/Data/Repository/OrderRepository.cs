using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data.Interfaces;
using Web_interface.Data.Models;

namespace Web_interface.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly AppDbContent appDBContent;
        private readonly ShopCar ShopCar;

        public OrderRepository(AppDbContent appDBContent, ShopCar ShopCar)
        {
            this.appDBContent = appDBContent;
            this.ShopCar = ShopCar;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();

            var items = ShopCar.ListShopItems;

            foreach (var el in items)
            {
                var orderdetail = new OrderDetail();

                orderdetail.Carud = el.car.id;
                orderdetail.Orderud = order.Id;
                orderdetail.price = el.car.price;
                orderdetail.car = el.car;
                orderdetail.order = order;
                appDBContent.OrderDetail.Add(orderdetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
