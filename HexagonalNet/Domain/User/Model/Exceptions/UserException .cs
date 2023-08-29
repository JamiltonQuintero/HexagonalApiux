using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Model.Exceptions
{
    public class UserException : Exception
    {
        public string ErrorMessage { get; set; }

        public UserException(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public override string Message => ErrorMessage ?? base.Message;
    }
}
