using System.ComponentModel.DataAnnotations.Schema;

namespace ProductCore.Models
{
    [Table("product")]
    public class Product
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("code")]
        public string Code { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("inventory_status")]
        public string InventoryStatus { get; set; }
        [Column("category")]
        public string Category { get; set; }
        [Column("image")]
        public string? Image { get; set; }
        [Column("rating")]
        public int? Rating { get; set; }
    }
}
