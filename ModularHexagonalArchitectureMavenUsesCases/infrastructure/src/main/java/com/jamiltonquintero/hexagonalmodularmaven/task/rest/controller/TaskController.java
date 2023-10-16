package com.jamiltonquintero.hexagonalmodularmaven.task.rest.controller;

import com.jamiltonquintero.hexagonalmodularmaven.task.model.dto.TaskDto;
import com.jamiltonquintero.hexagonalmodularmaven.task.model.dto.command.TaskCreateCommand;
import com.jamiltonquintero.hexagonalmodularmaven.task.model.dto.command.TaskEditCommand;
import com.jamiltonquintero.hexagonalmodularmaven.task.usescases.TaskCreation;
import com.jamiltonquintero.hexagonalmodularmaven.task.usescases.TaskDeletion;
import com.jamiltonquintero.hexagonalmodularmaven.task.usescases.TaskDisplay;
import com.jamiltonquintero.hexagonalmodularmaven.task.usescases.TaskModification;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/tasks")
public class TaskController {
    private final TaskCreation taskCreation;
    private final TaskDeletion taskDeletion;
    private final TaskDisplay taskDisplay;

    private final TaskModification taskModification;

    public TaskController(TaskCreation taskCreation, TaskDeletion taskDeletion, TaskDisplay taskDisplay, TaskModification taskModification) {
        this.taskCreation = taskCreation;
        this.taskDeletion = taskDeletion;
        this.taskDisplay = taskDisplay;
        this.taskModification = taskModification;
    }

    @PostMapping()
    public TaskDto create(@RequestBody TaskCreateCommand createCommand){
        return taskCreation.register(createCommand);
    }

    @PutMapping("/{id}")
    public TaskDto edit(@RequestBody TaskEditCommand taskEditCommand,
                        @PathVariable Long id){
        return taskModification.update(taskEditCommand, id);
    }

    @DeleteMapping("/{id}")
    public void deleteById(@PathVariable Long id){
        taskDeletion.deleteById(id);
    }

    @GetMapping("/{id}")
    public TaskDto getById(@PathVariable Long id){
        return taskDisplay.getById(id);
    }

    @GetMapping
    public List<TaskDto> getAll() {
        return taskDisplay.getAll();
    }

}
