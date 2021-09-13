﻿using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;
using System;
using BakeryManagementSystem.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryManagementSystemss .Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly BakeryDbContext _dbContext;

        public MessageRepository(BakeryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Message Add(Message message)
        {
            _dbContext.Messages.Add(message);
            _dbContext.SaveChanges();
            return message;
        }

        public void Delete(int messageId)
        {
            var message = FindById(messageId);

            if (message != null)
            {
                _dbContext.Messages.Remove(message);
                _dbContext.SaveChanges();
            }
        }

        public Message FindById(int messageId)
        {
            return _dbContext.Messages.FirstOrDefault(u => u.Id.Equals(messageId));
        }

        public Message Update(Message message)
        {
            _dbContext.Messages.Update(message);
            _dbContext.SaveChanges();
            return message;
        }
    }
}
