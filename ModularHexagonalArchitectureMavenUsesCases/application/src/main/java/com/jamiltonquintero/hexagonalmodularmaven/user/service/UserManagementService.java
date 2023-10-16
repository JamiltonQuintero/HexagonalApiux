package com.jamiltonquintero.hexagonalmodularmaven.user.service;


import com.jamiltonquintero.hexagonalmodularmaven.task.port.dao.TaskDao;
import com.jamiltonquintero.hexagonalmodularmaven.user.mapper.UserDtoMapper;
import com.jamiltonquintero.hexagonalmodularmaven.user.model.dto.UserDto;
import com.jamiltonquintero.hexagonalmodularmaven.user.model.dto.command.UserCreateCommand;
import com.jamiltonquintero.hexagonalmodularmaven.user.model.dto.command.UserEditCommand;
import com.jamiltonquintero.hexagonalmodularmaven.user.model.entity.User;
import com.jamiltonquintero.hexagonalmodularmaven.user.port.dao.UserDao;
import com.jamiltonquintero.hexagonalmodularmaven.user.port.repository.UserRepository;
import com.jamiltonquintero.hexagonalmodularmaven.user.usescases.UserCreation;
import com.jamiltonquintero.hexagonalmodularmaven.user.usescases.UserDeletion;
import com.jamiltonquintero.hexagonalmodularmaven.user.usescases.UserDisplay;
import com.jamiltonquintero.hexagonalmodularmaven.user.usescases.UserModification;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class UserManagementService implements UserCreation, UserDeletion, UserDisplay, UserModification {


    private final UserDao userDao;
    private final TaskDao taskDao;
    private final UserRepository userRepository;
    private final UserDtoMapper userDtoMapper;
    private final UserValidationAllowTasksAssignmentService userValidationAllowTasksAssignmentService;

    public UserManagementService(UserDao userDao, TaskDao taskDao, UserRepository userRepository, UserDtoMapper userDtoMapper,
                                 UserValidationAllowTasksAssignmentService userValidationAllowTasksAssignmentService) {
        this.userDao = userDao;
        this.taskDao = taskDao;
        this.userRepository = userRepository;
        this.userDtoMapper = userDtoMapper;
        this.userValidationAllowTasksAssignmentService = userValidationAllowTasksAssignmentService;
    }


    @Override
    public UserDto register(UserCreateCommand createCommand) {

        var userToCreate = new User()
                .requestToCreate(createCommand);
        var createduser =  userRepository.create(userToCreate);

        return userDtoMapper
                .toDto(createduser);
    }

    @Override
    public UserDto assignTasksToUserById(Long id, List<Long> tasksIds) {

        var user = userDao.getById(id);
        var tasksToDo = taskDao.getByIds(tasksIds);

        userValidationAllowTasksAssignmentService
                .execute(new ArrayList<>(user.getTasks()), tasksToDo);
        user.getTasks().addAll(tasksToDo);
        var userWithTasks = userRepository.update(user);

        return userDtoMapper
                .toDto(userWithTasks);
    }

    @Override
    public void deleteById(Long id) {
        var user = userDao.getById(id);
        userRepository.deleteById(user.getId());
    }

    @Override
    public UserDto getById(Long id) {
        return userDtoMapper
                .toDto(userDao.getById(id));
    }

    @Override
    public List<UserDto> getAll() {
        return userDao.getAll()
                .stream()
                .map(userDtoMapper::toDto)
                .collect(Collectors.toList());
    }

    @Override
    public UserDto update(UserEditCommand userEditCommand, Long id) {

        var currentUser = userDao.getById(id);
        var taskToUpdate = setValuesToUpdate(userEditCommand, currentUser);
        var updateduser = userRepository.update(taskToUpdate);

        return userDtoMapper
                .toDto(updateduser);
    }

    private static User setValuesToUpdate(UserEditCommand userEditCommand, User currentUser) {
        return new User(
                currentUser.getId(),
                userEditCommand.getName(),
                userEditCommand.getAge(),
                userEditCommand.getCountry(),
                currentUser.getTasks());
    }
}
