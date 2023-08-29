package com.jamiltonquintero.hexagonalmodularmaven.beanconfiguration;

import com.jamiltonquintero.hexagonalmodularmaven.user.service.UserValidationAllowTasksAssignmentService;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class UserBean {

    @Bean
    public UserValidationAllowTasksAssignmentService userValidationAllowTasksAssignmentService(){
        return new UserValidationAllowTasksAssignmentService();
    }

}
