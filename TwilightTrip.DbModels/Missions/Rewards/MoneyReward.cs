using System.ComponentModel.DataAnnotations;

namespace TwilightTrip.DbModels.Missions.Rewards
{
    public class MoneyReward : MissionRewardBase
    {
        [Required]
        public decimal Money { get; set; }
    }
}