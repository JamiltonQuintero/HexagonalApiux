using Domain.User.Port.Dao;
using Domain.User.Port.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Service
{
    public class UserDeleteService
    {
        private readonly IUserDao _userDao;
        private readonly IUserRepository _userRepository;

        public UserDeleteService(IUserDao userDao, IUserRepository userRepository)
        {
            _userDao = userDao;
            _userRepository = userRepository;
        }

        public void Execute(long id)
        {
            var user = _userDao.GetById(id);
            _userRepository.DeleteById(user.Id);
        }
    }
}
