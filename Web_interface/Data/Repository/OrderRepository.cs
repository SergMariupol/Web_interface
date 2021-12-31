using Microsoft.EntityFrameworkCore;
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
            var items = ShopCar.ListShopItems;
            double sum = 0.0;
            foreach (var el in items)
            {
                sum += Convert.ToDouble(el.car.price);
            }

            order.sum = sum;


            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();





            

            foreach (var el in items)
            {
                var orderdetail = new OrderDetail();

                orderdetail.Carud = el.car.id;
                orderdetail.NameGoods = el.car.name;
                orderdetail.Orderud = order.Id;
                orderdetail.price = el.car.price;
                orderdetail.car = el.car;
                orderdetail.order = order;
                appDBContent.OrderDetail.Add(orderdetail);

                
            }

       



            appDBContent.SaveChanges();
        }

        public IEnumerable<Order> OrderList => appDBContent.Order;
        public IEnumerable<OrderDetail> OrderDetailList => appDBContent.OrderDetail;

    }
}
