using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data.Interfaces;
using Web_interface.Data.Models;

namespace Web_interface.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDbContent appDBContent;
        public CategoryRepository(AppDbContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
