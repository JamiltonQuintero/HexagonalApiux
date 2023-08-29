using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Task.Command
{
    public class TaskDeleteHandler
    {
        private readonly TaskDeleteService _taskDeleteService;

        public TaskDeleteHandler(TaskDeleteService taskDeleteService)
        {
            _taskDeleteService = taskDeleteService;
        }

        public void Execute(long id)
        {
            _taskDeleteService.Execute(id);
        }
    }
}
