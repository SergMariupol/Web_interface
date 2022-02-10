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
    public class RegisterController : Controller
    {
        //private readonly IAllOrders _allOrders;

        //public OrderListController(IAllOrders allOrders)
        //{
        //    _allOrders = allOrders;
        //}


        public IActionResult RegisterWindow()
        {         
            return View();
        }

        [HttpPost]
        public IActionResult RegisterWindow(Register register)
        {




            return RedirectToAction("Complete");
        }
          
    
    public IActionResult Complete()
    {
        ViewBag.Message = "Регистрация успешна";
        return View();
    }

        public IActionResult RegisterWindowRegister()
        {
            return View();
        }
    }


        //// [HttpPost]
        // public ActionResult ReadOrderDetail(int id)
        // {
        //     IEnumerable<OrderDetail> OrderDetails;
        //     ViewBag.Title = "Заказы";



        //     OrderDetails = _allOrders.OrderDetailList.Where(i => i.Orderud == id);

        //    // OrderDetails = from OrderDetail in _allOrders.OrderDetailList where OrderDetail.Orderud == 1 select OrderDetail;


        //     OrderListViewModel objOrderDetails = new OrderListViewModel();

        //     objOrderDetails.OrderDetailList = OrderDetails;

        //     return View(objOrderDetails);
        // }
    }

