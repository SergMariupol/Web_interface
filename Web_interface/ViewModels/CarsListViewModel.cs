using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data.Models;

namespace Web_interface.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }
        public string currCategory { get; set; }
    }
}
