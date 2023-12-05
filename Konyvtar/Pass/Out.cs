using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pass
{
    public class Out
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public int B_ID { get; set; }
        [Required]
        public int P_ID { get; set; }
        [Required]
        public DateTime outcast {get; set; }
        [Required]
        public DateTime recast { get; set; }
    }
}
