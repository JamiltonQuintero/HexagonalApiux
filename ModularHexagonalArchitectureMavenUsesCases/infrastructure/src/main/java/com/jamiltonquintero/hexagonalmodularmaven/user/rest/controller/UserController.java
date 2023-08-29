package com.jamiltonquintero.hexagonalmodularmaven.user.rest.controller;

import com.jamiltonquintero.hexagonalmodularmaven.user.model.dto.UserDto;
import com.jamiltonquintero.hexagonalmodularmaven.user.model.dto.command.UserCreateCommand;
import com.jamiltonquintero.hexagonalmodularmaven.user.model.dto.command.UserEditCommand;
import com.jamiltonquintero.hexagonalmodularmaven.user.usescases.UserCreation;
import com.jamiltonquintero.hexagonalmodularmaven.user.usescases.UserDeletion;
import com.jamiltonquintero.hexagonalmodularmaven.user.usescases.UserDisplay;
import com.jamiltonquintero.hexagonalmodularmaven.user.usescases.UserModification;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/users")
public class UserController {

    private final UserCreation userCreation;
    private final UserDeletion userDeletion;
    private final UserDisplay userDisplay;
    private final UserModification userModification;

    public UserController(UserCreation userCreation, UserDeletion userDeletion, UserDisplay userDisplay, UserModification userModification) {
        this.userCreation = userCreation;
        this.userDeletion = userDeletion;
        this.userDisplay = userDisplay;
        this.userModification = userModification;
    }

    @PostMapping()
    public UserDto create(@RequestBody UserCreateCommand userCreateCommand){
        return userCreation.register(userCreateCommand);
    }

    @PutMapping("/{id}")
    public UserDto userEdit(@RequestBody UserEditCommand userEditCommand,
                            @PathVariable Long id){
        return userModification.update(userEditCommand, id);
    }

    @DeleteMapping("/{id}")
    public void deleteUserById(@PathVariable Long id){
        userDeletion.deleteById(id);
    }

    @PostMapping("/{id}/tasks")
    public void assignTasks(@PathVariable Long id , @RequestParam List<Long> tasksIds){
        userCreation.assignTasksToUserById(id, tasksIds);
    }

    @GetMapping("/{id}")
    public UserDto getById(@PathVariable long id){
        return userDisplay.getById(id);
    }

    @GetMapping
    public List<UserDto> getAll() {
        return userDisplay.getAll();
    }

}
