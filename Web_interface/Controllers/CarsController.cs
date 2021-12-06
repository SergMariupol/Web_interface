using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data.Interfaces;
using Web_interface.ViewModels;

namespace Web_interface.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Page with Avto";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = _allCars.Cars;
            obj.currCategory = "Avto";
            return View(obj);
        }


    }
}
