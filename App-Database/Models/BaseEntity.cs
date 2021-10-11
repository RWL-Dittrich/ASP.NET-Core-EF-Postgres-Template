using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_Database.Models
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }
    }
}
