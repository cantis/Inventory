using InventoryService.data;
using InventoryService.data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryService.manager
{
    public class ItemTypeManager
    {
        private readonly DataContext context;

        public ItemTypeManager(DataContext context)
        {
            this.context = context;
        }


        public ItemType GetItemType(int typeId)
        {

        }
    }
}
