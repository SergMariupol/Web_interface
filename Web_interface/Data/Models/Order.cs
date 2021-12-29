using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_interface.Data.Models
{
    public class Order
    {
        [BindNever]
        public int  Id { get; set; }
        [Display(Name = "Введите имя")]
        [StringLength(20)]
        [Required(ErrorMessage ="Длина имени не менее 5 символов")]
        public string Name { get; set; }
        [Display(Name = "Введите фамилию")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина фамилии не менее 5 символов")]
        public string surName { get; set; }
        [Display(Name = "Введите адрес")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина адреса не менее 5 символов")]
        public string adress { get; set; }
        [Display(Name = "Введите номер телефона")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина номера телефона не менее 10 символов")]
        public string phone { get; set; }
        [Display(Name = "Введите  Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина Emeil не менее 10 символов")]
        public string mail { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
