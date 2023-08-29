using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Task.Model.Entity
{
    public class TaskDateOfCreation
    {
        public DateTime DateOfCreation { get; private set; }

        public TaskDateOfCreation SetDateOfCreationDefaultValue()
        {
            DateOfCreation = DateTime.Now;
            return this;
        }
    }
}
