using System.Collections.Generic;
using BakeryManagementSystem.Models;
using CarRentalsSystem.Models;

namespace BakeryManagementSystem.Interface
{
    public interface IRoleService
    {
        public Role Add(Role role);

        public Role FindById(int id);

        public Role Update(Role role);

        public List<RoleViewModel> GetAllRoles();

        public void Delete(int id);
    }
}