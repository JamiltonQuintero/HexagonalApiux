using Domain.Task.Model.Dto.Command;
using Domain.User.Model.Dto.Command;
using Domain.User.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Task.Model.Entity
{
    public class WorkTask
    {
        public long Id { get; private set; }
        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public bool Completed { get; private set; }
        public DateTime DateOfCreation { get; private set; }
        public int TimeRequiredToComplete { get; private set; }
        public List<WorkUser> Users { get; private set; }

    }

}