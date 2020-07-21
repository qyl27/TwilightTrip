using System.ComponentModel.DataAnnotations;

namespace TwilightTrip.DbModels.Npcs
{
    public class Option
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string InOption { get; set; }

        [Required]
        public Conversation Owner { get; set; }

        [Required]
        public Conversation Then { get; set; }
    }
}
