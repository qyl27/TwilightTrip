using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        public List<ItemReward> Rewards { get; set; }

        public int ExperiencesReward { get; set; }

        public decimal MoneyReward { get; set; }
    }
}
