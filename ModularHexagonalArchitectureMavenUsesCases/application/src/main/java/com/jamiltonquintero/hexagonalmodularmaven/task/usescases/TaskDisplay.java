package com.jamiltonquintero.hexagonalmodularmaven.task.usescases;

import com.jamiltonquintero.hexagonalmodularmaven.task.model.dto.TaskDto;

import java.util.List;

public interface TaskDisplay {

    TaskDto getById(Long id);
    List<TaskDto> getAll();
}
