using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TwilightTrip.DbModels.Players
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int Experiences { get; set; }
        
        [Required]
        public decimal Money { get; set; }
        
        [Required]
        public decimal Points { get; set; }
        
        public List<Item> Inventory { get; set; }
        
        public Home Home { get; set; }
    }
}