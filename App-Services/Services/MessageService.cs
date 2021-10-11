using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using App_Database;
using App_Database.Models;
using App_Services.Interfaces;

namespace App_Services.Services
{
    public class MessageService : IMessageService
    {
        private readonly ApplicationDbContext _dbContext;

        public MessageService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Message>> GetMessages()
        {
            return await _dbContext.Messages.ToListAsync();
        }

        public async Task<Message> AddMessage(Message message)
        {
            await _dbContext.Messages.AddAsync(message);
            await _dbContext.SaveChangesAsync();
            return message;
        }
    }
}
