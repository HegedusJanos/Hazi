using System.ComponentModel.DataAnnotations;

namespace Konyvtar_Api
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]
        public string? Creators { get; set; }
        [Range(typeof(DateTime),"0-01-01","2023-12-31")]
        public DateTime CreatedDate { get; set; }
    }
}
