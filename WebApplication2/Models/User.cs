using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalFinanceManager.Models
{
    public class User : Entity
    {
      
        [BsonElement("Username")]
        [Required]
        public string Username { get; set; }
        
        [BsonElement("Password")]
        [Required]
        public string Password{ get; set; }

        [BsonElement("Birthday")]
        [Required]
        public DateTime Birthday { get; set; }
        
        [BsonElement("Email")]
        [Required]
        public string Email { get; set; }

        [BsonElement("WalletId")]
        public string WalletId { get; set; }
  }
}
