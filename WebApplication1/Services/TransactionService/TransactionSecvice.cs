using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services.TransactionService.Builder;
using WebApplication1.Services.TransactionService.Builder.Entities;
using WebApplication1.Services.UserServices;

namespace WebApplication1.Services.TransactionService
{
    public class TransactionSecvice : Service<Transaction>, ITransactionService
    {
        private Transaction _transaction;
        private bool AddTransactionToCurrentUser(User user)
        {
       
            user.Transactions.Add(_transaction);

            var userService = new UserService();
            _ = userService.UpdateObject(user).Result;
            return true;
        }
        public bool AddTransactionToUser(User user, ITransactionCreationRequest transactionCreationRequest)
        {
            ITransactionBuilder transactionBuilder = new TransactionBuilder();

            _transaction = transactionBuilder
                .SetBatch(transactionCreationRequest.Batch)
                .SetAmount(transactionCreationRequest.Amount)
                .Build();


            AddTransactionToCurrentUser(user);
            return true;
        }

        private void AddUserTransaction(Transaction transaction)
        {
            var db = GetDbContext();
            db.Transactions.Add(transaction);
            db.SaveChanges();
        }

     
    }
}
