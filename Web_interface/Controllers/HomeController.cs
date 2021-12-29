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
    public class HomeController : Controller
    {
        private readonly IAllCars _carRep;
   


        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;        
        }

        public ViewResult Index()
        {
            var homecars = new HomeViewModel { 
                FavCars = _carRep.getFavCars};
            
            return View(homecars);
        }
    }
}
