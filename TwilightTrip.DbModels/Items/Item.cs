using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TwilightTrip.DbModels.Enumerates;
using TwilightTrip.DbModels.Enumerates.Items;

namespace TwilightTrip.DbModels.Items
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [Required]
        public int MaxStackSize { get; set; }
        
        [Required]
        public PropertyFlag Properties { get; set; }
    }
}