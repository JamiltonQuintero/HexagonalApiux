using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Command
{
    public class UserDeleteHandler
    {
        private readonly UserDeleteService _userDeleteService;

        public UserDeleteHandler(UserDeleteService userDeleteService)
        {
            _userDeleteService = userDeleteService;
        }

        public void Execute(long id)
        {
            _userDeleteService.Execute(id);
        }
    }

}
