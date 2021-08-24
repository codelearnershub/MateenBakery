using BakeryManagementSystem.Models;

namespace BakeryManagementSystem.Interface
{
    public interface IMessageService
    {
        public Message Add(Message message);
      
        public Message FindById(int id);

        public Message Update(int messageId, Message message);
      
        public void Delete(int id);

    }
}