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
        [Required]
        public DateTime PurchaseDate { get; set; }

        [BsonElement("SalePrice")]
        [Required]
        public double SalePrice { get; set; }

        [BsonElement("SaleDate")]
        [Required]
        public DateTime SaleDate { get; set; }
  }
}
