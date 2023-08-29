using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Task.Model.Dto.Command
{
    public class TaskCreateCommand
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int TimeRequiredToComplete { get; set; }

    }
}
