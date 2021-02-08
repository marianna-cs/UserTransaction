using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class Service<T> where T : class
    {

        protected static UserContext GetDbContext() 
        {

            string connection = "Server=(localdb)\\mssqllocaldb;Database=userdb;Trusted_Connection=True;";
            var optionsBuilder = new DbContextOptionsBuilder<UserContext>();
            optionsBuilder.UseSqlServer(connection, options => options.EnableRetryOnFailure());
            var Db = new UserContext(optionsBuilder.Options);
            return Db;
        }

        public virtual async Task<int> UpdateObject(T addedObject) 
        {
            var db = GetDbContext();
            db.Update(addedObject);
            return  await db.SaveChangesAsync();
            
        }
    }
}
