using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data.Models;

namespace Web_interface.Data.Interfaces
{
   public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }//read all category
    }
}
