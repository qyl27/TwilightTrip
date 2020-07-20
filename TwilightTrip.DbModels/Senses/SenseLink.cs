using System.ComponentModel.DataAnnotations;

namespace TwilightTrip.DbModels.Senses
{
    public class SenseLink
    {
        [Key]
        public int Id { get; set; }

        public Sense Sense { get; set; }

        public Sense ToSense { get; set; }
    }
}
