using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Database.Models;
using App_Services.Interfaces;

namespace App_Server.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService _messageService;
        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Message>>> GetMessages()
        {
            var messages = await _messageService.GetMessages();

            return messages;
        }

        [HttpPost]
        public async Task<ActionResult<Message>> AddMessage(Message message)
        {
            var newMessage = await _messageService.AddMessage(message);

            return newMessage;
        }
    }
}
