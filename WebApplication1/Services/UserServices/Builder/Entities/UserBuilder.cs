
using System;
using WebApplication1.Models;
using WebApplication1.Services.UserServices.Validators;
using WebApplication1.Services.UserServices.Validators.Entities;

namespace WebApplication1.Services.UserServices.Builder.Entities
{
    /// <summary>
    /// Класс который строит модель пользователя
    /// </summary>
    public class UserBuilder : IUserBuilder
    {
        private IValidator<User> _validator;
        private User _user;
        public UserBuilder(IValidator<User> validator)
        {
            _validator = validator;
            _user = new User();
        }
        /// <summary>
        /// возвращаем собраный обьект полькователя
        /// </summary>
        /// <returns></returns>
        public User Build()
        {
            _user.CreatedAt = DateTime.Now;

            if (_validator.ExecuteValidator(_user))
            {
                return _user;
            }
            throw new Exception("User is invalid");
        }

        public IUserBuilder SetAge(int age)
        {
            _user.Age = age;
            return this;
        }

        public IUserBuilder SetFamilyName(string familyName)
        {
            _user.FamilyName = familyName;
            return this;
        }

        public IUserBuilder SetName(string name)
        {
            _user.Name = name;
            return this;
        }


    }
}
