using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Task.Command
{
    public class TaskCreateHandler
    {
        private readonly TaskCreateService _taskCreateService;
        private readonly TaskDtoMapper _taskDtoMapper;

        public TaskCreateHandler(TaskCreateService taskCreateService, TaskDtoMapper taskDtoMapper)
        {
            _taskCreateService = taskCreateService;
            _taskDtoMapper = taskDtoMapper;
        }

        public TaskDto Execute(TaskCreateCommand createCommand)
        {
            return _taskDtoMapper.ToDto(_taskCreateService.Execute(createCommand));
        }
    }
}
