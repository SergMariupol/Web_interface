using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data.Interfaces;
using Web_interface.Data.Models;

namespace Web_interface.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car{name = "Tesla",
                        shortDesc = "",
                        longDesk="", img="",
                        price=4500,
                        isFavourite =true,
                        available = true,
                        Categoty = _categoryCars.AllCategories.First()}
                };
            }
        }
           


        public IEnumerable<Car> getFavCars { get ; set ; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
    
    
}
