using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Services.UserServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Sdk;

namespace WebApplication1.Services.UserServices.Tests
{
    [TestClass()]
    public class UserServiceTests
    {
        [TestMethod()]
        public void AddUserTest()
        {
            UserService userService = new UserService();
            userService.AddUser("Vasia", "Pavlukhin",100);
        }
    }
}