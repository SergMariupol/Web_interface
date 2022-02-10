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
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;

        }

        
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.Category.categoryName);
                ViewBag.Title = "Автомобили";
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    //cars = _allCars.Cars.Where(i => i.Category.categoryName == "electro");
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Электромобили")).OrderBy(i=>i.id);
                    currCategory = "Электромобили";
                    ViewBag.Title = "Электромобили";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Класические автомобили")).OrderBy(i => i.id);
                    currCategory = "Класические автомобили";
                    ViewBag.Title = "Классика";
                }
          
   
                
            }
            

            
            CarsListViewModel objCar = new CarsListViewModel();
            objCar.AllCars = cars;
            objCar.currCategory = currCategory;
            return View(objCar);



            //ViewBag.Title = "Page with Avto";
            //CarsListViewModel obj = new CarsListViewModel();
            //obj.AllCars = _allCars.Cars;
            //obj.currCategory = "Avto";
            //return View(obj);
        }


    }
}
