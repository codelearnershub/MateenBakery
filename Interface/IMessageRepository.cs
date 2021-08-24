using BakeryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryManagementSystem.Interface
{
    public interface IMessageRepository
    {
        public Message Add(Message message);

        public Message FindById(int messageId);

        public Message Update(Message message);

        public void Delete(int messageId);
    }
}
