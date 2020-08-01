using System.ComponentModel.DataAnnotations;

namespace TwilightTrip.DbModels.Senses
{
    public class Sense
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        
    }
}