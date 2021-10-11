using System.Collections.Generic;
using System.Threading.Tasks;
using App_Database.Models;

namespace App_Services.Interfaces
{
    public interface IMessageService
    {
        Task<List<Message>> GetMessages();
        Task<Message> AddMessage(Message message);
    }
}