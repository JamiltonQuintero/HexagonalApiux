using Domain.User.Model.Entity;
using Domain.User.Port.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Service
{
    public class UserAllService
    {
        private readonly IUserDao _userDao;

        public UserAllService(IUserDao userDao)
        {
            _userDao = userDao;
        }

        public List<WorkUser> Execute()
        {
            return _userDao.GetAll();
        }
    }
}
