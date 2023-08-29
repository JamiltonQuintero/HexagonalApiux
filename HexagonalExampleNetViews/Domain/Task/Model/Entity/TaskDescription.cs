using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Task.Model.Entity
{
    public class TaskDescription
    {
        public string Description { get; private set; }
            
        public TaskDescription(string description) { 
        }
    }
}
