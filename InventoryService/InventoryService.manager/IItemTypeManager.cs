using System.Collections.Generic;
using InventoryService.data.Models;

namespace InventoryService.manager
{
    public interface IItemTypeManager
    {
        ItemType GetItemType(int typeId);
        List<ItemType> GetItemTypes();
    }
}