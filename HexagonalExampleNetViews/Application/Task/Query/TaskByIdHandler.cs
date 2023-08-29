using Domain.Task.Model.Dto;
using Domain.Task.Port.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Task.Query
{
    public class TaskByIdHandler
    {
        private readonly ITaskDao _taskDao;
        private readonly ITaskDtoMapper _taskDtoMapper;

        public TaskByIdHandler(ITaskDao taskDao, ITaskDtoMapper taskDtoMapper)
        {
            _taskDao = taskDao;
            _taskDtoMapper = taskDtoMapper;
        }

        public TaskDto Execute(long id)
        {
            return _taskDtoMapper.ToDto(_taskDao.GetById(id));
        }
    }
}
