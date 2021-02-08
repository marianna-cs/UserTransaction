using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services.TransactionService.Builder
{
    public interface ITransactionBuilder
    {
        public Transaction Build();

        public ITransactionBuilder SetBatch(string batch);
        public ITransactionBuilder SetAmount(decimal amount);

    }
}
