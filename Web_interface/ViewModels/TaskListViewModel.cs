using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data.Models;

namespace Web_interface.ViewModels
{
    public class TaskListViewModel
    {
        public IEnumerable<Project> ProjectList { get; set; }
        public IEnumerable<Web_interface.Data.Models.Task> TaskList { get; set; }
        public IEnumerable<TaskComments> TaskCommentsList { get; set; }
    }
}
