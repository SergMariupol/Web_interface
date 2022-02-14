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
        private readonly IAllRegister allRegister;

        

        public RegisterController(IAllRegister allRegister)
        {
            this.allRegister = allRegister;
           
        }

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



            allRegister.CreateRegister(register);



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

    }

