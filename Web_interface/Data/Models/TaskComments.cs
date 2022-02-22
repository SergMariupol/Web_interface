using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_interface.Data.Models
{
    public class TaskComments
    {
        public int id { get; set; }
        public int TaskId { get; set; }
        public byte CommentType { get; set; }
        public byte [] Content { get; set; }
    }
}
