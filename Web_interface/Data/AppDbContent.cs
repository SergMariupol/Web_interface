using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data.Models;

namespace Web_interface.Data
{
    public class AppDbContent : DbContext
    {
  public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
        {

        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCarItem> ShopCarItem { get; set; }
        public DbSet<Order> Order{ get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }


    }
}
