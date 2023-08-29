using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.User
{
    [ApiController]
    [Route("users")]
    public class UserQueryController : ControllerBase
    {
        private readonly UserByIdHandler _userByIdHandler;
        private readonly UserAllHandler _userAllHandler;

        public UserQueryController(UserByIdHandler userByIdHandler, UserAllHandler userAllHandler)
        {
            _userByIdHandler = userByIdHandler;
            _userAllHandler = userAllHandler;
        }

        [HttpGet("{id}")]
        public UserDto GetById(long id)
        {
            return _userByIdHandler.Execute(id);
        }

        [HttpGet]
        public List<UserDto> GetAll()
        {
            return _userAllHandler.Execute();
        }
    }
}
