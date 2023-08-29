using Domain.Task.Model.Constants;
using Domain.Task.Port.Dao;
using Domain.Task.Port.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Task.Service
{
    public class TaskDeleteService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskDao _taskDao;

        public TaskDeleteService(ITaskRepository taskRepository, ITaskDao taskDao)
        {
            _taskRepository = taskRepository;
            _taskDao = taskDao;
        }

        public void Execute(long id)
        {
            var task = _taskDao.GetById(id);

            if (task is null || task.Users.Users.Count() > 0)
            {
                throw new UserTaskAssignationException(
                    string.Format(TaskConstant.CURRENT_TASK_NOT_ALLOW_TO_DELETE, task.Name));
            }

            _taskRepository.DeleteById(id);
        }
    }
}
