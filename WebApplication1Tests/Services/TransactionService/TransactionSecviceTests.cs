using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Services.TransactionService;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Services.UserServices;

namespace WebApplication1.Services.TransactionService.Tests
{
    [TestClass()]
    public class TransactionSecviceTests
    {
        [TestMethod()]
        public void AddTransactionToUserTest()
        {
            TransactionSecvice transactionSecvice = new TransactionSecvice();
            var user = UserService.GetUserById(1);
            transactionSecvice.AddTransactionToUser(user, new TransactionCreationRequest("GHF854", 0.356m));
        }
    }
}