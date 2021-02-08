using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services.TransactionService
{
    public class TransactionCreationRequest : ITransactionCreationRequest
    {
        public TransactionCreationRequest(string batch, decimal amount)
        {
            Batch = batch ?? throw new ArgumentNullException(nameof(batch));
            Amount = amount;
        }

        public string Batch { get; }

        public decimal Amount { get; }
    }
}
