using System;
using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;

namespace BakeryManagementSystem.Service
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;
        
        private readonly IUserService _userService;

        public MessageService(IMessageRepository messageRepository, IUserService userService)
        {
            _messageRepository = messageRepository;
            _userService = userService;
        }

        public Message Add(Message message)
        {
            message = new Message
            {
                CreatedBy = _userService.FindUserById(message.UserId).Email,
                CreatedAt = DateTime.Now,
                Title = message.Title.ToUpper(),
                Content = message.Content,
                ReceiverId = message.ReceiverId,
                Reciver = message.Reciver
            };

            return _messageRepository.Add(message);
        }

        public Message FindById(int id)
        {
            return _messageRepository.FindById(id);
        }

        public Message Update(int messageId, Message message)
        {
            message = _messageRepository.FindById(messageId);
            if (message == null)
            {
                return null;
            }

            message.Title = message.Title.ToUpper();
            message.Content = message.Content;
            message.ReceiverId = message.ReceiverId;
            message.UpdatedAt = DateTime.Now;

            return _messageRepository.Update(message);
        }

        public void Delete(int id)
        {
            _messageRepository.Delete(id);
        }
    }
}