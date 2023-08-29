using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Model.Dto.Command
{
    public class UserCreateCommand
    {


        public string? Name { get; set; }
        public byte? Age { get; set; }
        public string? Country { get; set; }
    }
}
