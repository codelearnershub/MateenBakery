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
        
        public void DeleteRole(string name)
        {

            var role = FindRoleByName(name);

            if (role != null)
            {
                _dbContext.Roles.Remove(role);
                _dbContext.SaveChanges();
            }
        }

        public List<Role> GetAllRole()
        {
            return _dbContext.Roles.ToList();
        }
        
        
        public Role FindRoleByName(string name)
        {
            return _dbContext.Roles.FirstOrDefault(v => v.Name.Equals(name));
        }
     
        public List<UserRole> FindUserRoles(int userId)
        {
            return _dbContext.UserRoles.Where(ur => ur.UserId == userId).ToList();
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
