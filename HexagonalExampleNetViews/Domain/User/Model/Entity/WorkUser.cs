using Domain.Task.Model.Entity;
using Domain.User.Model.Dto.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Model.Entity
{
    public class WorkUser
    {
        public long Id { get; }
        public string? Name { get; }
        public byte? Age { get; }
        public string? Country { get; }
        public List<WorkTask> Tasks { get; }

    }
}
