using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models {
  public class User
    {
      [BsonId]
      [BsonRepresentation(BsonType.ObjectId)]
      public string Id { get; set; }

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

      public Wallet Wallet { get; set; }
  }
}
