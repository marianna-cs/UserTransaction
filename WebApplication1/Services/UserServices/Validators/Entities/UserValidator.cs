using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services.UserServices.Validators.Entities
{
    public class UserValidator : IValidator<User>
    {
        

        private const int MIN_AGE = 18;
        private const int MAX_AGE = 120;
        private const int MIN_NAME_LEN = 2;

        private bool ValidateAge(int age)
        {
            return age >= MIN_AGE && age <= MAX_AGE;
        }

        private bool ValidateNames(string name)
        {
            return !String.IsNullOrEmpty(name) && name.Length >= MIN_NAME_LEN;
        }

        public bool ExecuteValidator(User user)
        {
            bool result = true;
            result = result && ValidateAge(user.Age);
            result = result && ValidateNames(user.Name);
            result = result && ValidateNames(user.FamilyName);
            return result;
        }
        
    }
}
