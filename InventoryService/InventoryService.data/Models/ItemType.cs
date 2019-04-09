using System.ComponentModel.DataAnnotations;

namespace InventoryService.data.Models
{
    public class ItemType
    {
        [Key]
        public int TypeId { get; set; }
        public string Description { get; set; }
        public int Sort { get; set; }
    }
}
