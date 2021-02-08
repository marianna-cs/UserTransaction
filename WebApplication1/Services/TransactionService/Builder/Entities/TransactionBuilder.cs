using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services.TransactionService.Builder.Entities
{
    public class TransactionBuilder : ITransactionBuilder
    {
        private Transaction _transaction;
        public TransactionBuilder()
        {
            _transaction = new Transaction();
        }
        public Transaction Build()
        {
            
            _transaction.CreatedAt = DateTime.Now;
            return _transaction;


        }

        public ITransactionBuilder SetAmount(decimal amount)
        {
            _transaction.Amount = amount;
            return this;
        }

        public ITransactionBuilder SetBatch(string batch)
        {
            _transaction.Batch = batch;
            return this;
        }
    }
}
