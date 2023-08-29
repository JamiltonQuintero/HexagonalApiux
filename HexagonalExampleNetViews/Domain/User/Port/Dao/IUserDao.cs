using Domain.User.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Port.Dao
{
    public interface IUserDao
    {
        WorkUser GetById(long id);
        List<WorkUser> GetAll();
    }
}
