using InventoryService.data;
using InventoryService.data.Models;
using System.Collections.Generic;
using System.Linq;

namespace InventoryService.manager
{
    public class ItemTypeManager : IItemTypeManager
    {
        private readonly DataContext _context;

        public ItemTypeManager(DataContext context)
        {
            _context = context;
        }

        public List<ItemType> GetItemTypes()
        {
            return _context.ItemTypes.ToList();
        }

        public ItemType GetItemType(int typeId)
        {
            return _context.ItemTypes.FirstOrDefault(x => x.TypeId == typeId);
        }
    }
}
