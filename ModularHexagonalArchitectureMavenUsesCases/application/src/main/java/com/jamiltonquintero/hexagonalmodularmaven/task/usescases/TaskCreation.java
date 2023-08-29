package com.jamiltonquintero.hexagonalmodularmaven.task.usescases;

import com.jamiltonquintero.hexagonalmodularmaven.task.model.dto.TaskDto;
import com.jamiltonquintero.hexagonalmodularmaven.task.model.dto.command.TaskCreateCommand;

public interface TaskCreation {

    TaskDto register(TaskCreateCommand createCommand);

}
