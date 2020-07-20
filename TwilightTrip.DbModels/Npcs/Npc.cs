using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TwilightTrip.DbModels.Senses;

namespace TwilightTrip.DbModels.Npcs
{
    public class Npc
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [Required]
        public bool IsHidden { get; set; }
        
        [Required]
        public Sense AtSense { get; set; }
        
        public List<NpcConversation> Talks { get; set; }
        
    }
}
