using System.Collections.Generic;
using BakeryManagementSystem.Models;

namespace BakeryManagementSystem.Interface
{
    public interface IUserRoleService
    {
        public UserRole FindUserRoles(int userId);
        
        public UserRole Add(int userId, int roleId);

        public UserRole FindById(int id);

        public string FindRole(int userId);
        public void Delete(int id);
        UserRole Add(UserRole userRole);
    }
}