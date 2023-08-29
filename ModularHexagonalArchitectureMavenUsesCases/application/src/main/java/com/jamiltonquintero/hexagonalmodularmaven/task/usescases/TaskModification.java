package com.jamiltonquintero.hexagonalmodularmaven.task.usescases;

import com.jamiltonquintero.hexagonalmodularmaven.task.model.dto.TaskDto;
import com.jamiltonquintero.hexagonalmodularmaven.task.model.dto.command.TaskEditCommand;

public interface TaskModification {

    TaskDto update(TaskEditCommand taskEditCommand, Long id);

}
