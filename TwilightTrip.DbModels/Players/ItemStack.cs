using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TwilightTrip.DbModels.Items;

namespace TwilightTrip.DbModels.Players
{
    public class ItemStack
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public Player Owner { get; set; }
        
        [Required]
        public Item Item { get; set; }
        
        [Required]
        public int Count { get; set; }
    }
}