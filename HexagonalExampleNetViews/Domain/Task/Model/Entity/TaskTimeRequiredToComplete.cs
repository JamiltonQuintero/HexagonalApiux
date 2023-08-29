using Domain.Task.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Task.Model.Entity
{
    public class TaskTimeRequiredToComplete
    {
        private static readonly int MAXIMUM_ALLOW_TIME = 8;
        public int TimeRequiredToComplete { get; private set; }

        public TaskTimeRequiredToComplete(int timeRequiredToComplete)
        {
            ValidTime(timeRequiredToComplete);
            TimeRequiredToComplete = timeRequiredToComplete;
        }

        private void ValidTime(int timeRequiredToComplete)
        {
            if (timeRequiredToComplete == 0)
            {
                throw new TaskException("TimeRequiredToComplete don't be 0 or less");
            }

            if (timeRequiredToComplete > MAXIMUM_ALLOW_TIME)
            {
                throw new TaskException("TimeRequiredToComplete don't be bigger than 8 hours");
            }
        }

    }
}
