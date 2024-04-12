using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, Range(1, Int32.MaxValue)]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public string Category { get; set; }
        public string Shelf { get; set; }
        [Required, Range(0, Int32.MaxValue)]
        public int Count { get; set; }
        public string Description { get; set; }


    }
}
