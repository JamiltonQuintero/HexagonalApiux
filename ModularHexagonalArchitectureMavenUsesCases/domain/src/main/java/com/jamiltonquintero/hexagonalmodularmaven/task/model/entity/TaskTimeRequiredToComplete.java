package com.jamiltonquintero.hexagonalmodularmaven.task.model.entity;

import lombok.Getter;

@Getter
public class TaskTimeRequiredToComplete {

    private int timeRequiredToComplete;

    public TaskTimeRequiredToComplete(int timeRequiredToComplete) {

        this.timeRequiredToComplete = timeRequiredToComplete;
    }
}
