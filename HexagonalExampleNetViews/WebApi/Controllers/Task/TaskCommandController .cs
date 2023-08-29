using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.Task
{
    [ApiController]
    [Route("[controller]")]
    public class TaskCommandController : ControllerBase
    {
        private readonly TaskCreateHandler _taskCreateHandler;
        private readonly TaskEditHandler _taskEditHandler;
        private readonly TaskDeleteHandler _taskDeleteHandler;

        public TaskCommandController(TaskCreateHandler taskCreateHandler, TaskEditHandler taskEditHandler, TaskDeleteHandler taskDeleteHandler)
        {
            _taskCreateHandler = taskCreateHandler;
            _taskEditHandler = taskEditHandler;
            _taskDeleteHandler = taskDeleteHandler;
        }

        [HttpPost]
        public ActionResult<TaskDto> Create([FromBody] TaskCreateCommand createCommand)
        {
            return _taskCreateHandler.Execute(createCommand);
        }

        [HttpPut("{id}")]
        public ActionResult<TaskDto> Edit([FromBody] TaskEditCommand taskEditCommand, [FromRoute] long id)
        {
            return _taskEditHandler.Execute(taskEditCommand, id);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById([FromRoute] long id)
        {
            _taskDeleteHandler.Execute(id);
            return Ok(); // Puedes retornar OK o NoContent dependiendo de tus preferencias
        }

    }
}
