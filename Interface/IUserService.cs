using BakeryManagementSystem.Models;
using BakeryManagementSystem.Models.ViewModel;

namespace BakeryManagementSystem.Interface
{
    public interface IUserService
    {
        public User Add(User user);
     
        public User FindUserById(int id);

        public User Update(int userId, User user);
        
        public void Delete(int id);

        public User LoginUser(string email, string password);

        public void RegisterUser(RegisterViewModel model);

    }
}