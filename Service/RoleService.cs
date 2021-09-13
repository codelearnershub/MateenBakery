using System;
using System.Collections.Generic;
using System.Linq;
using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;
using CarRentalsSystem.Models;

namespace BakeryManagementSystem.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public Role Add(Role role)
        {
            role = new Role
            {
                Id = role.Id,
                Name = role.Name,
                CreatedAt = DateTime.Now
            };

            return _roleRepository.Add(role);
        }

        public Role FindById(int id)
        {
            return _roleRepository.FindById(id);
        }
        
        public Role FindRoleByName(string name)
        {
            return _roleRepository.FindRoleByName(name);
        }

        public Role Update(Role role)
        {
            role = _roleRepository.FindById(role.Id);
            if (role == null)
            {
                return null;
            }

            role.Name = role.Name;
            role.UpdatedAt = DateTime.Now;

            return _roleRepository.Update(role);
        }

        public List<RoleViewModel> GetAllRoles()
        {
            var category = _roleRepository.GetAllRole().Select(c => new RoleViewModel
            {
                Id = c.Id,
                Name = c.Name,
                CreatedAt = DateTime.Now

            }).ToList();
            return category;
        }

        public void Delete(int id)
        {
            _roleRepository.Delete(id);
        }
    }
}