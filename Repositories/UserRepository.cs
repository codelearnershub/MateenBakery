using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;
using BakeryManagementSystem.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryManagementSystem.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BakeryDbContext _dbContext;

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
            var user = FindById(userId);

            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }

        public User FindById(int userId)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id.Equals(userId));
        }

        public User Update(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
            return user;
        }
    }
}
