using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_interface.Data.Models
{
    public class ShopCar
    {
        private readonly AppDbContent appDBContent;
        public ShopCar(AppDbContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string  ShopCarId { get; set; }
        public List<ShopCarItem> ListShopItems { get; set; }

        public static ShopCar GetCar(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContent>();
            string shopcarid = session.GetString("CarId") ?? Guid.NewGuid().ToString();
            session.SetString("CarId", shopcarid);
            return new ShopCar(context) { ShopCarId = shopcarid };
        }

        public void AddToCar(Car car)
        {
            this.appDBContent.ShopCarItem.Add(new ShopCarItem
            {ShopCarId = ShopCarId,
            car = car,
            price =car.price
            });
            appDBContent.SaveChanges();
        }

        public List<ShopCarItem> getItems()
        {
            return appDBContent.ShopCarItem.Where(c => c.ShopCarId == ShopCarId).Include(s => s.car).ToList();
        }
    }
}
