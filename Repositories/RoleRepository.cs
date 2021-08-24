using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;
using BakeryManagementSystem.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryManagementSystem.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly BakeryDbContext _dbContext;

        public RoleRepository(BakeryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Role Add(Role role)
        {
            _dbContext.Roles.Add(role);
            _dbContext.SaveChanges();
            return role;
        }

        public void Delete(int roleId)
        {
            var role = FindById(roleId);

            if (role != null)
            {
                _dbContext.Roles.Remove(role);
                _dbContext.SaveChanges();
            }
        }

        public Role FindById(int roleId)
        {
            return _dbContext.Roles.FirstOrDefault(u => u.Id.Equals(roleId));
        }

        public Role Update(Role role)
        {
            _dbContext.Roles.Update(role);
            _dbContext.SaveChanges();
            return role;
        }
    }
}
