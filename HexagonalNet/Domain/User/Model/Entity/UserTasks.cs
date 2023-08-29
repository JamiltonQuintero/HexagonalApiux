using Domain.Task.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Model.Entity
{
    public class UserTasks
    {
   

        public UserTasks(List<WorkTask> tasks)
        {
            Tasks = tasks ?? new List<WorkTask>();
        }

        public List<WorkTask> Tasks { get; }
    }
}
