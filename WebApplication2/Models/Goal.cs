using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalFinanceManager.Models
{
    public class Goal : Entity
    {

        [BsonElement("Name")]
        [Required]
        public string Name { get; set; }

        [BsonElement("Description")]
        [Required]
        public string Description { get; set; }

        [BsonElement("WalletId")]
        [Required]
        public string WalletId { get; set; }

        public IList<Investment> Investments { get; set; }
  }
}
