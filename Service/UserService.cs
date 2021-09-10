using System;
using System.Security.Cryptography;
using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;
using BakeryManagementSystem.Models.ViewModel;
using BakeryManagementSystem.Repositories;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace BakeryManagementSystem.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        
        private readonly IRoleRepository _roleRepository;

        public UserService(IUserRepository userRepository, IRoleRepository roleRepository)
        {
            _userRepository = userRepository;
            
            _roleRepository = roleRepository;
        }
        
        public User LoginUser(string email, string password)
        {
            User user = _userRepository.FindUserByEmail(email);

            if (user == null)
            {
                Console.WriteLine("User not found");
                return null;
            }

            string hashedPassword = HashPassword(password, user.HashSalt);

            if (user.PasswordHash.Equals(hashedPassword))
            {
                Console.WriteLine("User is found");

                return user;
            }
            return null;
        }
        
        /*public void RegisterUser(RegisterViewModel model)
        {
            byte[] salt = new byte[128 / 8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string saltString = Convert.ToBase64String(salt);

            string hashedPassword = HashPassword(model.Password, saltString);

            var role = _roleRepository.FindByRoleName("Staff");
            User user = new User
            {
                Name = model.Name,
                Email = model.Email,
                PhoneNo = model.Phone,
                Address = model.Address
            };
            var userRole = new UserRole
            {
                User = user,
                UserId = user.Id,
                Role = role,
                RoleId = role.Id
            };
            user.UserRoles.Add(userRole);

            _userRepository.Add(user);
        }*/

        public User Add(User user)
        {
            user = new User
            {
                CreatedAt = DateTime.Now,
                Address = user.Address,
                Email = user.Email,
                Name = user.Name,
                PhoneNo = user.PhoneNo,
                HashSalt = user.HashSalt,
                PasswordHash = user.PasswordHash
            };

            return _userRepository.Add(user);
        }

        public User FindUserById(int id)
        {
            return _userRepository.FindUserById(id);
        }

        public User Update(int userId, User user)
        {
            user = _userRepository.FindUserById(userId);
            if (user == null)
            {
                return null;
            }

            user.CreatedAt = DateTime.Now;
            user.Address = user.Address;
            user.Email = user.Email;
            user.Name = user.Name;
            user.PhoneNo = user.PhoneNo;
            user.PasswordHash = user.PasswordHash;

            return _userRepository.Update(user);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }
        
        private string HashPassword(string password, string salt)
        {
            byte[] saltByte = Convert.FromBase64String(salt);
            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: saltByte,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            Console.WriteLine($"Hashed: {hashed}");

            return hashed;
        }
        
         public void RegisterUser(RegisterViewModel model)
        {
            byte[] salt = new byte[128 / 8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string saltString = Convert.ToBase64String(salt);

            string hashedPassword = HashPassword(model.Password, saltString);
            
        
            User user = new User
            {   
                Email =model.Email,
               
                HashSalt = saltString,
                PasswordHash = hashedPassword
                
            };

            foreach(var role in model.Roles)
            {
                var userRole = new UserRole
                {
                    User = user,
                    UserId = user.Id,
                    Role = role,
                    RoleId = role.Id
                };
                user.UserRoles.Add(userRole);
            }
            _userRepository.Add(user);
        }
    }
}