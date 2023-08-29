package com.jamiltonquintero.hexagonalmodularmaven.task.service;

import com.jamiltonquintero.hexagonalmodularmaven.task.mapper.TaskDtoMapper;
import com.jamiltonquintero.hexagonalmodularmaven.task.model.constant.TaskConstant;
import com.jamiltonquintero.hexagonalmodularmaven.task.model.dto.TaskDto;
import com.jamiltonquintero.hexagonalmodularmaven.task.model.dto.command.TaskCreateCommand;
import com.jamiltonquintero.hexagonalmodularmaven.task.model.dto.command.TaskEditCommand;
import com.jamiltonquintero.hexagonalmodularmaven.task.model.entity.Task;
import com.jamiltonquintero.hexagonalmodularmaven.task.model.exception.TaskException;
import com.jamiltonquintero.hexagonalmodularmaven.task.port.dao.TaskDao;
import com.jamiltonquintero.hexagonalmodularmaven.task.port.repository.TaskRepository;
import com.jamiltonquintero.hexagonalmodularmaven.task.usescases.TaskCreation;
import com.jamiltonquintero.hexagonalmodularmaven.task.usescases.TaskDeletion;
import com.jamiltonquintero.hexagonalmodularmaven.task.usescases.TaskDisplay;
import com.jamiltonquintero.hexagonalmodularmaven.task.usescases.TaskModification;
import com.jamiltonquintero.hexagonalmodularmaven.user.model.exception.UserTaskAssignationException;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class TaskManagementService implements TaskCreation, TaskDeletion, TaskDisplay, TaskModification {

    private final TaskDao taskDao;
    private final TaskRepository taskRepository;
    private final TaskSuperComplexService taskSuperComplexService;
    private final TaskDtoMapper taskDtoMapper;

    public TaskManagementService(TaskDao taskDao, TaskRepository taskRepository, TaskSuperComplexService taskSuperComplexService, TaskDtoMapper taskDtoMapper) {
        this.taskDao = taskDao;
        this.taskRepository = taskRepository;
        this.taskSuperComplexService = taskSuperComplexService;
        this.taskDtoMapper = taskDtoMapper;
    }

    @Override
    public TaskDto register(TaskCreateCommand createCommand) {
        var calculatedTime = taskSuperComplexService.execute();

        if(calculatedTime > createCommand.getTimeRequiredToComplete()){
            throw new TaskException("Super complex exception");
        }

        var taskToCreate = new Task()
                .requestToCreate(createCommand);
        var createdTask = taskRepository.create(taskToCreate);

        return taskDtoMapper.toDto(createdTask);

    }

    @Override
    public void deleteById(Long id) {
        var task = taskDao.getById(id);

        if(task.getUsers().size() > 0){
            throw new UserTaskAssignationException(
                    String.format(TaskConstant.CURRENT_TASK_NOT_ALLOW_TO_DELETE, task.getName()));
        }
        taskRepository.deleteById(id);
    }

    @Override
    public TaskDto getById(Long id) {
        return taskDtoMapper.toDto(taskDao.getById(id));
    }

    @Override
    public List<TaskDto> getAll() {
        return taskDao.getAll()
                .stream()
                .map(taskDtoMapper::toDto)
                .collect(Collectors.toList());
    }

    @Override
    public TaskDto update(TaskEditCommand taskEditCommand, Long id) {

        var currentTask = taskDao.getById(id);
        var taskToUpdate = setValuesToUpdate(taskEditCommand, currentTask);
        var updatedTask = taskRepository.update(taskToUpdate);

        return taskDtoMapper.toDto(updatedTask);


    }

    private static Task setValuesToUpdate(TaskEditCommand taskEditCommand, Task currentTask) {
        return new Task(
                currentTask.getId(),
                taskEditCommand.getName(),
                taskEditCommand.getDescription(),
                currentTask.getCompleted(),
                currentTask.getDateOfCreation(),
                taskEditCommand.getTimeRequiredToComplete(),
                currentTask.getUsers());
    }
}
