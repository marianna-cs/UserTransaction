
using WebApplication1.Models;
using WebApplication1.Services.UserServices.Builder;
using WebApplication1.Services.UserServices.Builder.Entities;
using System.Linq;
using WebApplication1.Services.UserServices.Validators.Entities;

namespace WebApplication1.Services.UserServices
{
    public class UserService : Service<User>, IUserService
    {
        private User _user;

        public bool AddUser(IUserBuilder userBuilder)
        {
            
            _user = userBuilder.Build();

            AddUserToDb(_user);
            return true;
        }

        public bool AddUser(string name, string familyName, int age)
        {

            //Инициализируем строителя пользователя
            IUserBuilder userBuilder = new UserBuilder(new UserValidator());
            
            //Задаем значения пользователю
            _user = userBuilder
                .SetName(name)
                .SetFamilyName(familyName)
                .SetAge(age)
                .Build();

            //Добавляем пользователя в бд
            AddUserToDb(_user);
            return true;
        }

        private void AddUserToDb(User user)
        {
            var db = GetDbContext();
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static User GetUserById(int id)
        {
            var context = GetDbContext();
            var user = context.Users.Find(id);
            return user;
        }
        private void LoadUserTransactionsIfNotLoaded() 
        {
            if (_user.Transactions.Count() == 0) 
            {
                var dbContext = GetDbContext();
                dbContext.Attach(_user);
                dbContext.Entry(_user).Collection(u => u.Transactions).Load();
            }
        }
        public decimal GetUserBalance()
        {
            LoadUserTransactionsIfNotLoaded();
            var balance = _user.Transactions.Sum(t => t.Amount);
            return balance;
        }
    }
}
