using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Services.UserServices.Builder;

namespace WebApplication1.Services.UserServices
{
    public interface IUserService
    {
        /// <summary>
        /// Добавляет пользователя в бд
        /// </summary>
        /// <param name="userBuilder"> обьект строителя пользователя</param>
        /// <returns></returns>
        public bool AddUser(IUserBuilder userBuilder);
        public bool AddUser(string name, string familyName, int age);
    }
}
