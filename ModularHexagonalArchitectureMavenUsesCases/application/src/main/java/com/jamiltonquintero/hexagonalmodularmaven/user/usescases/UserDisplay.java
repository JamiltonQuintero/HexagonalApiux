package com.jamiltonquintero.hexagonalmodularmaven.user.usescases;

import com.jamiltonquintero.hexagonalmodularmaven.user.model.dto.UserDto;

import java.util.List;

public interface UserDisplay {

    UserDto getById(Long id);
    List<UserDto> getAll();
}
