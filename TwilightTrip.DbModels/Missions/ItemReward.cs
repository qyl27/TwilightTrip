using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TwilightTrip.DbModels.Player;

namespace TwilightTrip.DbModels.Missions
{
    public class ItemReward
    {
        [Key]
        public int Id { get; set; }

        public List<Mission> Missions { get; set; }

        public Item Item { get; set; }

        public int Count { get; set; }
    }
}
