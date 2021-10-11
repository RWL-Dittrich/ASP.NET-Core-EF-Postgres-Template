using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Database.Models
{
    public class Message : BaseEntity
    {
        public string Username { get; set; }

        public string MessageContent { get; set; }
    }
}
