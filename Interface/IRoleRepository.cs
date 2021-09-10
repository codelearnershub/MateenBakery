using BakeryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryManagementSystem.Interface
{
    public interface IRoleRepository
    {
        public Role Add(Role role);

        public Role FindById(int roleId);

        public Role Update(Role role);

        public void Delete(int roleId);

        public List<Role> GetAllRole();
        public Role FindRoleByName(string name);
        public List<UserRole> FindUserRoles(int userId);
    }
}
