using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Task.Model.Entity
{
    public class TaskCompleted
    {
        public static readonly bool COMPLETED_DEFAULT_VALUE = false;

        public bool IsCompleted { get; private set; }

        public TaskCompleted SetCompletedDefaultValue()
        {
            IsCompleted = COMPLETED_DEFAULT_VALUE;
            return this;
        }
    }
}
