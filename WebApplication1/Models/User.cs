using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        public User()
        {
            Transactions = new List<Transaction>();
        }

        public int Id { get; private set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int Age { get; set; }
        public List<Transaction> Transactions { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
