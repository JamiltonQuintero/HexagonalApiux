using Domain.Task.Port.Dao;
using Domain.User.Model.Entity;
using Domain.User.Port.Dao;
using Domain.User.Port.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Service
{
    public class UserAssignTasksService
    {
        private readonly IUserDao _userDao;
        private readonly ITaskDao _taskDao;
        private readonly IUserRepository _userRepository;
        private readonly UserValidationAllowTasksAssignmentService _validationService;

        public UserAssignTasksService(IUserDao userDao, ITaskDao taskDao, IUserRepository userRepository, UserValidationAllowTasksAssignmentService validationService)
        {
            _userDao = userDao;
            _taskDao = taskDao;
            _userRepository = userRepository;
            _validationService = validationService;
        }

        public WorkUser Execute(long id, List<long> tasksIds)
        {
            var user = _userDao.GetById(id);
            var tasksToDo = _taskDao.GetByIds(tasksIds);

            _validationService.Execute(user.Tasks.ToList(), tasksToDo.ToList());

            user.Tasks.AddRange(tasksToDo);

            return _userRepository.Update(user);
        }
    }
}
