using System;
using System.Collections.Generic;
using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;

namespace BakeryManagementSystem.Service
{
    public class UserRoleService : IUserRoleService
    {
        public readonly IUserRoleService _userRoleRepository;
        public UserRoleService(IUserRoleService userRoleRepository)
        {
            _userRoleRepository = userRoleRepository;
        }
        public UserRole FindUserRoles(int userId)
        {
            return _userRoleRepository.FindUserRoles(userId);
        }
        
        public UserRole Add(int userId, int roleId)
        {
            var userRole = new UserRole
            {
                CreatedAt = DateTime.Now,
                UserId = userId,
                RoleId = roleId
            };

            return _userRoleRepository.Add(userRole);
        }

        public UserRole FindById(int id)
        {
            return _userRoleRepository.FindById(id);
        }

        public string FindRole(int userId)
        {
            return _userRoleRepository.FindRole(userId);
           
        }
        public void Delete(int id)
        {
            _userRoleRepository.Delete(id);
        }

        public UserRole Add(UserRole userRole)
        {
            throw new NotImplementedException();
        }
    }
}