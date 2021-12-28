using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Web_interface.Data.Interfaces;
using Web_interface.Data.Models;
using Web_interface.Data.Repository;
using Web_interface.ViewModels;

namespace Web_interface.Controllers
{
    public class ShopCarController : Controller
    {
        private readonly IAllCars _carRep;
        private readonly ShopCar _shopcar;


        public ShopCarController(IAllCars carRep, ShopCar shopcar)
        {
            _carRep = carRep;
            _shopcar = shopcar;
        }
        public ViewResult Index()
        {
            var items = _shopcar.getItems();
            _shopcar.ListShopItems = items;
            var obj = new ShopCarViewModel
            {
                shopCar = _shopcar
            };
        return View(obj);
        }

        public RedirectToRouteResult AddToCar(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopcar.AddToCar(item);               
            }
            return RedirectToAction("Index");
        }
    }
}
