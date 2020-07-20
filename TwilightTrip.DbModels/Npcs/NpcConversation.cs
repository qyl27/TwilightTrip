using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TwilightTrip.Utilities.Enumerates;

namespace TwilightTrip.DbModels.Npcs
{
    public class NpcConversation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Npc Owner { get; set; }

        public NpcConversationType Type { get; set; }

        public string Content { get; set; }

        public List<NpcOption> Options { get; set; }

        public List<Mission> Mission { get; set; }
    }
}
