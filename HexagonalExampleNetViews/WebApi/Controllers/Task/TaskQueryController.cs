using Application.Task.Query;
using Domain.Task.Model.Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.Task
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskQueryController : ControllerBase
    {
        private readonly TaskByIdHandler _taskByIdHandler;
        private readonly TaskAllHandler _taskAllHandler;

        public TaskQueryController(TaskByIdHandler taskByIdHandler, TaskAllHandler taskAllHandler)
        {
            _taskByIdHandler = taskByIdHandler;
            _taskAllHandler = taskAllHandler;
        }

        [HttpGet("{id}")]
        public ActionResult<TaskDto> GetById(long id)
        {
            return _taskByIdHandler.Execute(id);
        }

        [HttpGet]
        public ActionResult<IEnumerable<TaskDto>> GetAll()
        {
            return _taskAllHandler.Execute();
        }
    }
}
