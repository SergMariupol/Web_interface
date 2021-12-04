using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_interface.Data.Models
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesk { get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; }
        public int available { get; set; }
        public int categoryID { get; set; }
        public virtual Category Categoty { get; set;}
    }
}
