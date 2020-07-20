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
        public List<NpcConversation> Owner { get; set; }

        [Required]
        public NpcConversationType Type { get; set; }

        [Required]
        public string Content { get; set; }

        public List<NpcOption> Options { get; set; }

        public Mission Mission { get; set; }
    }
}
