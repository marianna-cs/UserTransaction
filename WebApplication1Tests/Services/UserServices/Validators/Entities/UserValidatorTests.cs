using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Services.UserServices.Validators.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Services.UserServices.Builder;
using Microsoft.AspNetCore.Identity;
using WebApplication1.Models;

namespace WebApplication1.Services.UserServices.Validators.Entities.Tests
{
    [TestClass()]
    public class UserValidatorTests
    {
        [TestMethod()]
        public void ExecuteValidatorTest()
        {
            User user = new User() {
                Age = 0,
                Name="Marianna",
                FamilyName="Holovata"
            
            };

            UserValidator userValidator = new UserValidator();
            var result = userValidator.ExecuteValidator(user);

        }
    }
}