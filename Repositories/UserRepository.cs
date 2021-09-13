using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;
using BakeryManagementSystem.Context;
using System.Linq;

namespace BakeryManagementSystem.Repositories
{
    public abstract class UserRepository : IUserRepository
    {
        private static BakeryDbContext _dbContext;

        public UserRepository(BakeryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User Add(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user;
        }

        public void Delete(int userId)
        {
            var user = FindUserById(userId);

            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }

        public User FindUserById(int userId)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id.Equals(userId));
        }
        public User FindUserByEmail(string email)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Email.Equals(email));
        }
        
        public User Update(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
            return user;
        }
    }
}
