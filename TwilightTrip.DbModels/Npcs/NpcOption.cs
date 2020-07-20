using System.ComponentModel.DataAnnotations;

namespace TwilightTrip.DbModels.Npcs
{
    public class NpcOption
    {
        [Key]
        public int Id { get; set; }

        public string Option { get; set; }

        public NpcConversation Owner { get; set; }

        public NpcConversation Then { get; set; }
    }
}
