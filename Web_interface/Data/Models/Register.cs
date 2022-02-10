using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_interface.Data.Models
{
    public class Register
    {
        [BindNever]
        public int  Id { get; set; }
        [BindNever]
        public double sum { get; set; }


        [Display(Name = "Введите логин")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string Login { get; set; }


        [Display(Name = "Введите пароль")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина фамилии не менее 5 символов")]
        public string Password1 { get; set; }



        [Display(Name = "Введите повторно пароль")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина адреса не менее 5 символов")]
        public string Password2 { get; set; }


       
    }
}
