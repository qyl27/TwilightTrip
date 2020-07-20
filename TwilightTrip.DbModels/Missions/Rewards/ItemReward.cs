using System.ComponentModel.DataAnnotations;
using TwilightTrip.DbModels.Player;

namespace TwilightTrip.DbModels.Missions.Rewards
{
    public class ItemReward : MissionRewardBase
    {
        [Required]
        public Item Item { get; set; }
        
        [Required]
        public int Count { get; set; }
    }
}
