
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DbSeeder 
    {
        private UserContext _db;
        public DbSeeder(UserContext db)
        {
            _db = db;
        }
        public async Task Seed()
        {
           /* _db.User.Add(new User { Name = "Vasia", Balance = 3 });
            _db.User.Add(new User { Name = "Kolia", Balance = 5 });
            _db.User.Add(new User { Name = "Masia", Balance = 8 });
            _db.User.Add(new User { Name = "Asia", Balance = 5 });
            _db.User.Add(new User { Name = "Yasia", Balance = 1000 });*/

          //  await _db.SaveChangesAsync();

            
        }
    }
}
