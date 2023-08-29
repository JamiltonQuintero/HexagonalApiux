using Domain.Task.Model.Dto;
using Domain.Task.Port.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Task.Query
{
    public class TaskAllHandler
    {
        private readonly ITaskDao _taskDao;
        private readonly ITaskDtoMapper _taskDtoMapper;

        public TaskAllHandler(ITaskDao taskDao, ITaskDtoMapper taskDtoMapper)
        {
            _taskDao = taskDao;
            _taskDtoMapper = taskDtoMapper;
        }

        public List<TaskDto> Execute()
        {
            return _taskDao.GetAll().Select(_taskDtoMapper.ToDto).ToList();
        }
    }
}
