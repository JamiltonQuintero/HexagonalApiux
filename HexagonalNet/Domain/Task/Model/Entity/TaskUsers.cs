using Domain.User.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Task.Model.Entity
{
    public class TaskUsers
    {
        public List<WorkUser> Users { get; private set; }
    }
}
