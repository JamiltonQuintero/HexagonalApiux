using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Command
{
    public class UserAssignTasksHandler
    {
        private readonly UserAssignTasksService _userAssignTasksService;
        private readonly UserDtoMapper _userDtoMapper;

        public UserAssignTasksHandler(UserAssignTasksService userAssignTasksService, UserDtoMapper userDtoMapper)
        {
            _userAssignTasksService = userAssignTasksService;
            _userDtoMapper = userDtoMapper;
        }

        public UserDto Execute(long id, List<long> tasksIds)
        {
            return _userDtoMapper.ToDto(_userAssignTasksService.Execute(id, tasksIds));
        }
    }
}
