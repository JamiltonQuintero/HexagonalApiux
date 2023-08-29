using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Task.Model.Dto
{
    public class TaskDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TimeRequiredToComplete { get; set; }


        public TaskDto(long id, string name, string description, int timeRequiredToComplete)
        {
            Id = id;
            Name = name;
            Description = description;
            TimeRequiredToComplete = timeRequiredToComplete;
        }
    }
}
