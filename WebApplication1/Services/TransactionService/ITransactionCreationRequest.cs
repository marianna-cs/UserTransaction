using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services.TransactionService
{
    public interface ITransactionCreationRequest
    {
        public string Batch { get; }
        public decimal Amount { get; }
    }
}
