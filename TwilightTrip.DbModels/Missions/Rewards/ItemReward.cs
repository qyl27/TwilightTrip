using TwilightTrip.DbModels.Player;

namespace TwilightTrip.DbModels.Missions.Rewards
{
    public class ItemReward : MissionRewardBase
    {
        public Item Item { get; set; }

        public int Count { get; set; }
    }
}
