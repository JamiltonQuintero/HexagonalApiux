using Domain.Task.Model.Entity;
using Domain.User.Model.Constants;
using Domain.User.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Service
{
    public class UserValidationAllowTasksAssignmentService
    {
        public void Execute(List<WorkTask> currentTasks, List<WorkTask> tasksToDo)
        {
            int totalTimeInTasks = GetRequirementTimeToDo(currentTasks, tasksToDo);

            if (totalTimeInTasks > 8)
            {
                throw new UserTaskAssignationException(string.Format(UserConstant.CURRENT_USER_NOT_ALLOW_TO_DO_TASKS, totalTimeInTasks));
            }
        }

        private int GetRequirementTimeToDo(List<WorkTask> currentTasks, List<WorkTask> tasksToDo)
        {
            int timeInCurrentTasks = currentTasks.Sum(task => task.TimeRequiredToComplete);
            int timeInTasksToDo = tasksToDo.Sum(task => task.TimeRequiredToComplete);

            return timeInCurrentTasks + timeInTasksToDo;
        }
    }
}
