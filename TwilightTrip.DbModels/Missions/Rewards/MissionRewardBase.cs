using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TwilightTrip.DbModels.Enumerates;

namespace TwilightTrip.DbModels.Missions.Rewards
{
    public abstract class MissionRewardBase
    {
        [Key]
        public int Id { get; set; }

        public List<Mission> Missions { get; set; }

        [Required]
        public MissionRewardType Type { get; set; }
    }
}
