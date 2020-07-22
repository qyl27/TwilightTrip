using System.ComponentModel.DataAnnotations;
using TwilightTrip.DbModels.Players;

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
