using System.ComponentModel.DataAnnotations;

namespace InventoryService.manager.DTOs
{
    public class ItemTypeDto
    {
        public int TypeID { get; set; }
        [Required(ErrorMessage = "Type Name is Required")]
        public string Description { get; set; }
        public int Sort { get; set; }
    }
}
