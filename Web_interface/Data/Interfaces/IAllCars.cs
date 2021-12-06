using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data.Models;

namespace Web_interface.Data.Interfaces
{
   public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; set; }
        Car getObjectCar(int carId);
    }
}
