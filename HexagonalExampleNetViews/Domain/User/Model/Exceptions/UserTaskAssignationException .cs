using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Model.Exceptions
{
    public class UserTaskAssignationException : Exception
    {
        public string ErrorMessage { get; set; }

        public UserTaskAssignationException(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public override string Message => ErrorMessage ?? base.Message;
    }
}
