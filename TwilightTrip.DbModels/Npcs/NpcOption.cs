using System.ComponentModel.DataAnnotations;

namespace TwilightTrip.DbModels.Npcs
{
    public class NpcOption
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Option { get; set; }

        [Required]
        public Conversation Owner { get; set; }

        [Required]
        public Conversation Then { get; set; }
    }
}
