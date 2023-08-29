package com.jamiltonquintero.hexagonalmodularmaven.beanconfiguration;

import com.jamiltonquintero.hexagonalmodularmaven.task.service.TaskSuperComplexService;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class TaskBean {

    @Bean
    public TaskSuperComplexService taskSuperComplexService(){
        return new TaskSuperComplexService();
    }

}
