using Domain.User.Model.Entity;
using Domain.User.Port.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Service
{
    public class UserByIdService
    {
        private readonly IUserDao _userDao;

        public UserByIdService(IUserDao userDao)
        {
            _userDao = userDao;
        }

        public WorkUser Execute(long id)
        {
            return _userDao.GetById(id);
        }
    }
}
