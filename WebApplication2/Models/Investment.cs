using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalFinanceManager.Models
{
    public class Investment : Entity
    {
        [BsonElement("PurchasePrice")]
        [Required]
        public double PurchasePrice { get; set; }

        [BsonElement("PurchaseDate")]

        public DateTime PurchaseDate { get; set; }

        [BsonElement("SalePrice")]
        public double SalePrice { get; set; }

        [BsonElement("SaleDate")]
        public DateTime SaleDate { get; set; }

        [BsonElement("GoalId")]
        [Required]
        public string GoalId { get; set; }
    }
}
