using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data.Models;

namespace Web_interface.Data
{
    public class DBObjects
    {
        public static void Initial(AppDbContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                {
                    name = "Tesla",
                    shortDesc = "",
                    longDesk = "",
                    img = "/img/Tesla.jpg",
                    price = 4500,
                    isFavourite = true,
                    available = true,
                    Category =  Categories["Электромобили"]
                },

                    new Car
                    {
                        name = "Tesla_Truck",
                        shortDesc = "",
                        longDesk = "",
                        img = "/img/tesla_truck.jpg",
                        price = 4500,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },

                    new Car
                    {
                        name = "BMW",
                        shortDesc = "",
                        longDesk = "",
                        img = "/img/BMW.jpg",
                        price = 4500,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Класические автомобили"]
                    });
            }

            content.SaveChanges();


        }
        public static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                    new Category{categoryName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category{categoryName = "Класические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                        category.Add(el.categoryName, el); 
                }
                return category;
            }
        }
    }
}