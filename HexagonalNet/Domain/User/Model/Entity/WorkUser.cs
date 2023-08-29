using Domain.Task.Model.Entity;
using Domain.User.Model.Dto.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Model.Entity
{
    public class WorkUser
    {
        private readonly UserId _id;
        private readonly UserName _name;
        private readonly UserAge _age;
        private readonly UserCountry _country;
        private readonly UserTasks _tasks;

        public WorkUser(long id, string name, byte age, string country, List<WorkTask> tasks)
        {
            _id = new UserId(id);
            _name = new UserName(name);
            _age = new UserAge(age);
            _country = new UserCountry(country);
            _tasks = new UserTasks(tasks);
        }

        public WorkUser(long id, string name, byte age, string country)
        {
            _id = new UserId(id);
            _name = new UserName(name);
            _age = new UserAge(age);
            _country = new UserCountry(country);
        }

        public WorkUser()
        {
        }

        public WorkUser Create(UserCreateCommand userCreateCommand)
        {
            _name = new UserName(userCreateCommand.Name);
            _age = new UserAge(userCreateCommand.Age);
            _country = new UserCountry(userCreateCommand.Country);
            return this;
        }

        public long Id => _id.Value;
        public string? Name => _name.Value;
        public byte? Age => _age.Value;
        public string? Country => _country.Value;
        public List<WorkTask> Tasks => _tasks.Values;

        public class UserId
        {
            public long Value { get; }

            public UserId(long value)
            {
                Value = value;
            }
        }

        public class UserName
        {
            public string? Value { get; }

            public UserName(string? value)
            {
                Value = value;
            }
        }

        public class UserAge
        {
            public byte? Value { get; }

            public UserAge(byte? value)
            {
                Value = value;
            }
        }

        public class UserCountry
        {
            public string? Value { get; }

            public UserCountry(string? value)
            {
                Value = value;
            }
        }

        public class UserTasks
        {
            public List<WorkTask> Values { get; }

            public UserTasks(List<WorkTask> tasks)
            {
                Values = tasks ?? new List<WorkTask>();
            }
        }
    }

}
