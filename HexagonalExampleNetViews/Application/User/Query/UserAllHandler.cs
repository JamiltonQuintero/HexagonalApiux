using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Query
{
    public class UserAllHandler
    {
        private readonly UserAllService _userAllService;
        private readonly UserDtoMapper _userDtoMapper;

        public UserAllHandler(UserAllService userAllService, UserDtoMapper userDtoMapper)
        {
            _userAllService = userAllService;
            _userDtoMapper = userDtoMapper;
        }

        public List<UserDto> Execute()
        {
            return _userAllService.Execute()
                    .Select(_userDtoMapper.ToDto)
                    .ToList();
        }
    }
}
