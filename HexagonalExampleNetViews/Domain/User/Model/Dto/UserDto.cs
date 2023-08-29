using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Model.Dto
{
    public class UserDto
    {
        public UserDto(long id, string name, byte age, string country)
        {
            Id = id;
            Name = name;
            Age = age;
            Country = country;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public string Country { get; set; }
    }
}
