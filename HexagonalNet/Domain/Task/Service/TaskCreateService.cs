using Domain.Task.Model.Dto.Command;
using Domain.Task.Model.Entity;
using Domain.Task.Model.Exceptions;
using Domain.Task.Port.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Task.Service
{
    public class TaskCreateService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly TaskSuperComplexService _taskSuperComplexService;

        public TaskCreateService(ITaskRepository taskRepository, TaskSuperComplexService taskSuperComplexService)
        {
            _taskRepository = taskRepository;
            _taskSuperComplexService = taskSuperComplexService;
        }

        public WorkTask Execute(TaskCreateCommand createCommand)
        {
            var calculatedTime = _taskSuperComplexService.Execute();

            if (calculatedTime > createCommand.TimeRequiredToComplete)
            {
                throw new TaskException("Super complex exception");
            }

            var taskToCreate = new WorkTask().RequestToCreate(createCommand);

            return _taskRepository.Create(taskToCreate);
        }
    }
}
