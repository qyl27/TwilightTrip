using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TwilightTrip.DbModels.Enumerates;
using TwilightTrip.DbModels.Missions;

namespace TwilightTrip.DbModels.Npcs
{
    public class Conversation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Npc Owner { get; set; }

        [Required]
        public NpcConversationType Type { get; set; }

        [Required]
        public string Content { get; set; }

        public Option From { get; set; }
        
        public List<Option> Options { get; set; }

        public Mission Mission { get; set; }
    }
}
