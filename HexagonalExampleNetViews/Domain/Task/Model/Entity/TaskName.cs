using Domain.Task.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Task.Model.Entity
{
    public class TaskName
    {
        public static readonly int MAXIMUM_ALLOW_LETTERS = 100;
        public string Name { get; private set; }

        public TaskName(string name)
        {
            ToValidName(name);
            Name = name;
        }

        private void ToValidName(string name)
        {
            if (name.Length == 0)
            {
                throw new TaskException("Name is mandatory");
            }

            if (name.Length > MAXIMUM_ALLOW_LETTERS)
            {
                throw new TaskException("Name don't be bigger than 100 characters");
            }

        }
    }
}
