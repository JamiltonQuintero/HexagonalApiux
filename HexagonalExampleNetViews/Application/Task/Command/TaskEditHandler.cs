using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Task.Command
{
    public class TaskEditHandler
    {
        private readonly TaskEditService _taskEditService;
        private readonly TaskDtoMapper _taskDtoMapper;

        public TaskEditHandler(TaskEditService taskEditService, TaskDtoMapper taskDtoMapper)
        {
            _taskEditService = taskEditService;
            _taskDtoMapper = taskDtoMapper;
        }

        public TaskDto Execute(TaskEditCommand taskEditCommand, long id)
        {
            return _taskDtoMapper.ToDto(_taskEditService.Execute(taskEditCommand, id));
        }
    }
}
