package com.jamiltonquintero.hexagonalmodularmaven.user.usescases;

import com.jamiltonquintero.hexagonalmodularmaven.user.model.dto.UserDto;
import com.jamiltonquintero.hexagonalmodularmaven.user.model.dto.command.UserCreateCommand;

import java.util.List;

public interface UserCreation {

    UserDto register(UserCreateCommand createCommand);

    UserDto assignTasksToUserById(Long id, List<Long> tasksIds);

}
