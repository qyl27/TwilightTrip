using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TwilightTrip.DbModels.Missions.Rewards;

namespace TwilightTrip.DbModels.Missions
{
    public class Mission
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public Mission Next { get; set; }

        public List<MissionRewardBase> Rewards { get; set; }
    }
}
