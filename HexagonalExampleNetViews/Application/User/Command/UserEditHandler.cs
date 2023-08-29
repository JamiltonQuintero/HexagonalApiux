using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Command
{
    public class UserEditHandler
    {
        private readonly UserEditService _userEditService;
        private readonly UserDtoMapper _userDtoMapper;

        public UserEditHandler(UserEditService userEditService, UserDtoMapper userDtoMapper)
        {
            _userEditService = userEditService;
            _userDtoMapper = userDtoMapper;
        }

        public UserDto Execute(UserEditCommand userEditCommand, long id)
        {
            return _userDtoMapper.ToDto(_userEditService.Execute(userEditCommand, id));
        }
    }
}
