using System.ComponentModel.DataAnnotations;

namespace TwilightTrip.DbModels.Npcs
{
    public class NpcConversation
    {
        public int NpcId { get; set; }
        
        [Required]
        public Npc Npc { get; set; }
        
        public int ConversationId { get; set; }
        
        [Required]
        public Conversation Conversation { get; set; }
    }
}