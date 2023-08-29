using Domain.User.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Port.Repository
{
    public interface IUserRepository
    {
        WorkUser Create(WorkUser user);
        void DeleteById(long id);
        WorkUser Update(WorkUser user);
    }
}
