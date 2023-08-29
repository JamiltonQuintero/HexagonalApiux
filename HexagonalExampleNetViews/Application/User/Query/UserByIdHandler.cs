using Domain.User.Model.Dto;
using Domain.User.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Query
{
    public class UserByIdHandler
    {
        private readonly UserByIdService _userByIdService;
        private readonly UserDtoMapper _userDtoMapper;

        public UserByIdHandler(UserByIdService userByIdService, UserDtoMapper userDtoMapper)
        {
            _userByIdService = userByIdService;
            _userDtoMapper = userDtoMapper;
        }

        public UserDto Execute(long id)
        {
            return _userDtoMapper.ToDto(_userByIdService.Execute(id));
        }
    }
}
