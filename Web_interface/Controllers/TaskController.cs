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
    public class TaskController : Controller
    {
        private readonly IAllRegister allRegister;

        

        public TaskController(IAllRegister allRegister)
        {
            this.allRegister = allRegister;           
        }




        public IActionResult TaskWindow()
        {         
            return View();
        }



    //    [HttpPost]
    //    public IActionResult RegisterWindow(Register register)
    //    {



    //        allRegister.CreateRegister(register);



    //        return RedirectToAction("Complete");
    //    }
          
    
    //public IActionResult Complete()
    //{
    //    ViewBag.Message = "Регистрация успешна";
    //    return View();
    //}

    //    public IActionResult RegisterWindowRegister()
    //    {
    //        return View();
    //    }
    }

}

