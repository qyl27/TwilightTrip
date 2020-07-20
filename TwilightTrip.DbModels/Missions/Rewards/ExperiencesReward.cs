using System.ComponentModel.DataAnnotations;

namespace TwilightTrip.DbModels.Missions.Rewards
{
    public class ExperiencesReward : MissionRewardBase
    {
        [Required]
        public int Experiences { get; set; }
    }
}
