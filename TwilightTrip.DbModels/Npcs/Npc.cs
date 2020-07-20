using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TwilightTrip.DbModels.Npcs
{
    public class Npc
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<NpcConversation> Talks { get; set; }
    }
}
