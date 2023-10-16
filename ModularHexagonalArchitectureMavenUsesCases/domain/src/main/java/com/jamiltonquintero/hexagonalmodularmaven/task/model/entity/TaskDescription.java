package com.jamiltonquintero.hexagonalmodularmaven.task.model.entity;

import com.jamiltonquintero.hexagonalmodularmaven.task.model.exception.TaskException;
import lombok.Getter;


@Getter
public class TaskDescription {

    private static final int MAX_ALLOW_LENGTH = 100;
    private String description;

    public TaskDescription(String description) {
        validateDescription(description);
        this.description = description;
    }

    private void validateDescription(String description) {

        if(description.length() > MAX_ALLOW_LENGTH){
            throw new TaskException("");
        }

        if(description.contains("E")){
            throw new TaskException("");
        }

    }
}
