package com.jamiltonquintero.hexagonalmodularmaven.user.usescases;

import com.jamiltonquintero.hexagonalmodularmaven.user.model.dto.UserDto;
import com.jamiltonquintero.hexagonalmodularmaven.user.model.dto.command.UserEditCommand;

public interface UserModification {

    UserDto update(UserEditCommand userEditCommand, Long id);

}
