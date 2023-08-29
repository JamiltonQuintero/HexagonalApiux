using Domain.User.Model.Dto.Command;
using Domain.User.Model.Entity;
using Domain.User.Port.Dao;
using Domain.User.Port.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Service
{
    public class UserEditService
    {
        private readonly IUserDao _userDao;
        private readonly IUserRepository _userRepository;

        public UserEditService(IUserDao userDao, IUserRepository userRepository)
        {
            _userDao = userDao;
            _userRepository = userRepository;
        }

        public WorkUser Execute(UserEditCommand userEditCommand, long id)
        {
            var currentUser = _userDao.GetById(id);
            var userToUpdate = new WorkUser(currentUser.Id, userEditCommand.Name, userEditCommand.Age, userEditCommand.Country, currentUser.Tasks.ToList());

            return _userRepository.Update(userToUpdate);
        }
    }
}
