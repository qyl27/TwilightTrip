using System;

namespace TwilightTrip.DbModels.Enumerates.Items
{
    [Flags]
    public enum PropertyFlag
    {
        None = 0,
        Tradable = 1, 
        Wearable = 2, 
        Usable = 4
    }
}