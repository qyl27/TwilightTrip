using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TwilightTrip.DbModels.Senses
{
    public class SenseLink
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public Sense FromSense { get; set; }
        
        [Required]
        public Sense ToSense { get; set; }
    }
}