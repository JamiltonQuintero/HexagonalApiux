using Domain.Task.Model.Dto.Command;
using Domain.User.Model.Dto.Command;
using Domain.User.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Task.Model.Entity
{
    public class WorkTask
    {
        private readonly TaskId _id;
        private readonly TaskName _name;
        private readonly TaskDescription _description;
        private readonly TaskCompleted _completed;
        private readonly TaskDateOfCreation _dateOfCreation;
        private readonly TaskTimeRequiredToComplete _timeRequiredToComplete;
        private readonly TaskUsers _users;

        public WorkTask()
        {
        }

        public WorkTask(long id,
                    string name,
                    string description,
                    bool completed,
                    DateTime dateOfCreation,
                    int timeRequiredToComplete,
                    List<WorkUser> users)
        {
            _id = new TaskId(id);
            _name = new TaskName(name);
            _description = new TaskDescription(description);
            _completed = new TaskCompleted(completed);
            _dateOfCreation = new TaskDateOfCreation(dateOfCreation);
            _timeRequiredToComplete = new TaskTimeRequiredToComplete(timeRequiredToComplete);
            _users = new TaskUsers(users);
        }
        public WorkTask RequestToCreate(TaskCreateCommand createCommand)
        {
            _name = new UserName(createCommand.Name);
            _age = new UserAge(createCommand.getAge());
            _country = new UserCountry(createCommand.getCountry());
            return this;
        }

        public long Id => _id.Value;
        public string Name => _name.Value;
        public string Description => _description.Value;
        public bool Completed => _completed.Value;
        public DateTime DateOfCreation => _dateOfCreation.Value;
        public int TimeRequiredToComplete => _timeRequiredToComplete.Value;
        public List<WorkUser> Users => _users.Values;

 

        public class TaskId
        {
            public long Value { get; }

            public TaskId(long value)
            {
                Value = value;
            }
        }

        public class TaskName
        {
            public string Value { get; }

            public TaskName(string value)
            {
                Value = value;
            }
        }

        public class TaskDescription
        {
            public string Value { get; }

            public TaskDescription(string value)
            {
                Value = value;
            }
        }

        public class TaskCompleted
        {
            public bool Value { get; }

            public TaskCompleted(bool value)
            {
                Value = value;
            }
        }

        public class TaskDateOfCreation
        {
            public DateTime Value { get; }

            public TaskDateOfCreation(DateTime value)
            {
                Value = value;
            }
        }

        public class TaskTimeRequiredToComplete
        {
            public int Value { get; }

            public TaskTimeRequiredToComplete(int value)
            {
                Value = value;
            }
        }

        public class TaskUsers
        {
            public List<WorkUser> Values { get; }

            public TaskUsers(List<WorkUser> users)
            {
                Values = users;
            }
        }

    }
}
