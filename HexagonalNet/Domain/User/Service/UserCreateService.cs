using Domain.User.Model.Dto.Command;
using Domain.User.Model.Entity;
using Domain.User.Port.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Service
{
    public class UserCreateService
    {
        private readonly IUserRepository _userRepository;

        public UserCreateService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public WorkUser Execute(UserCreateCommand userCreateCommand)
        {
            var userToCreate = new WorkUser().Create(userCreateCommand);
            return _userRepository.Create(userToCreate);
        }
    }
}
