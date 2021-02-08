using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services.TransactionService.Builder;

namespace WebApplication1.Services.TransactionService
{
    interface ITransactionService
    {
       // public bool AddTransactionToUser(User user);
        public bool AddTransactionToUser(User user, ITransactionCreationRequest transactionCreationRequest);
    }
}
