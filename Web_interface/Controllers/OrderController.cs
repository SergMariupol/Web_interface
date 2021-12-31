using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data.Interfaces;
using Web_interface.Data.Models;

namespace Web_interface.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allorders;
        private readonly ShopCar ShopCar;

        public OrderController(IAllOrders allorders, ShopCar ShopCar)
        {
            this.allorders = allorders;
            this.ShopCar = ShopCar;
        }
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            ShopCar.ListShopItems = ShopCar.getItems();
            if(ShopCar.ListShopItems.Count == 0)
            {
                ModelState.AddModelError("", "У вас должны быть товары");
            }
            if (ModelState.IsValid)
            {
                allorders.CreateOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        } 
        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно сохранен";
            return View();
        }
    }
}
