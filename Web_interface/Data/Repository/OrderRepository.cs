﻿using System;
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

            var items = ShopCar.ListShopItems;

            foreach (var el in items)
            {
                var orderdetail = new OrderDetail()
                {

                    Card = el.car.id,
                    Orderd = order.Id,
                    price = el.car.price
                };
                appDBContent.OrderDetail.Add(orderdetail);
            }
            appDBContent.SaveChanges();
        }
    }
}