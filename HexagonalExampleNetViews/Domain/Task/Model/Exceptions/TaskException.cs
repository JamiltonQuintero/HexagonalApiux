using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Task.Model.Exceptions
{
    public class TaskException : Exception
    {
        public string ErrorMessage { get; set; }

        public TaskException(string errorMessage) : base(errorMessage)
        {
            this.ErrorMessage = errorMessage;
        }

    }
}
