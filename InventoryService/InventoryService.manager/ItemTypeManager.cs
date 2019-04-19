using InventoryService.data;
using InventoryService.data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace InventoryService.manager
{
    public class ItemTypeManager : IItemTypeManager
    {
        private readonly DataContext _context;
        private readonly ItemTypeManager _manager;

        public ItemTypeManager(DataContext context, ItemTypeManager manager)
        {
            _context = context;
            _manager = manager;
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
