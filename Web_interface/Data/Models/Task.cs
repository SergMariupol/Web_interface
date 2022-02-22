using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_interface.Data.Models
{
    public class Task
    {
        public int id { get; set; }
        public string TaskName { get; set; }
        public int ProjectId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CancelDate { get; set; }
        public DateTime CreatelDate { get; set; }
        public DateTime UpdatelDate { get; set; }
    }
}
