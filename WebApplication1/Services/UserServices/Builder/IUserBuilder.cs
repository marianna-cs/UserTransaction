using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services.UserServices.Builder
{
    public interface IUserBuilder
    {
        public User Build();
        public IUserBuilder SetName(string name);
        public IUserBuilder SetFamilyName(string familyName);
        public IUserBuilder SetAge(int age);

    }
}
