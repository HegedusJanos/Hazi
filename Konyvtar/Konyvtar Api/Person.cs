using System.ComponentModel.DataAnnotations;

namespace Konyvtar_Api
{
    public class Person
    {
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? AdressT { get; set; }
        [Required]
        public string? AdressU { get; set; }
        public int? AdressHN { get; set; }
        [Required]
        [Range(typeof(DateTime), "1900-01-01","2022-12-31")]
        public DateTime BYear { get; set; }
    }
}
