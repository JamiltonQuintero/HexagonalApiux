using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Command
{
    public class UserCreateHandler
    {
        private readonly UserCreateService _userCreateService;
        private readonly UserDtoMapper _userDtoMapper;

        public UserCreateHandler(UserCreateService userCreateService, UserDtoMapper userDtoMapper)
        {
            _userCreateService = userCreateService;
            _userDtoMapper = userDtoMapper;
        }

        public UserDto Execute(UserCreateCommand userCreateCommand)
        {
            return _userDtoMapper.ToDto(_userCreateService.Execute(userCreateCommand));
        }
    }

}
