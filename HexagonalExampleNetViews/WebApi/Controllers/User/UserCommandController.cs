using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.User
{
    [ApiController]
    [Route("[controller]")]
    public class UserCommandController : ControllerBase
    {
        private readonly UserCreateHandler _userCreateHandler;
        private readonly UserEditHandler _userEditHandler;
        private readonly UserDeleteHandler _userDeleteHandler;
        private readonly UserAssignTasksHandler _userAssignTasksHandler;

        public UserCommandController(
            UserCreateHandler userCreateHandler,
            UserEditHandler userEditHandler,
            UserDeleteHandler userDeleteHandler,
            UserAssignTasksHandler userAssignTasksHandler)
        {
            _userCreateHandler = userCreateHandler;
            _userEditHandler = userEditHandler;
            _userDeleteHandler = userDeleteHandler;
            _userAssignTasksHandler = userAssignTasksHandler;
        }

        [HttpPost]
        public UserDto Create([FromBody] UserCreateCommand userCreateCommand)
        {
            return _userCreateHandler.Execute(userCreateCommand);
        }

        [HttpPut("{id}")]
        public UserDto UserEdit([FromBody] UserEditCommand userEditCommand, [FromRoute] long id)
        {
            return _userEditHandler.Execute(userEditCommand, id);
        }

        [HttpDelete("{id}")]
        public void DeleteUserById([FromRoute] long id)
        {
            _userDeleteHandler.Execute(id);
        }

        [HttpPost("{id}/tasks")]
        public void AssignTasks([FromRoute] long id, [FromQuery] List<long> tasksIds)
        {
            _userAssignTasksHandler.Execute(id, tasksIds);
        }
    }
}
