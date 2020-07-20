using System.ComponentModel.DataAnnotations;

namespace TwilightTrip.DbModels.Missions.Rewards
{
    public class PointsReward : MissionRewardBase
    {
        [Required]
        public decimal Points { get; set; }
    }
}