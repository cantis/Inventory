using InventoryService.data;
using InventoryService.data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryService.manager
{
    /// <summary>
    /// Item Type Manager
    /// </summary>
    public class ItemTypeManager
    {
        private readonly DataContext _context;

        /// <summary>
        /// Create a new ItemType Manager object
        /// </summary>
        /// <param name="context">Dabase Context</param>
        public ItemTypeManager(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets a Single Item Type
        /// </summary>
        /// <param name="typeId">TypeId to Get</param>
        /// <returns>ItemType Object</returns>
        public async Task<ItemType> GetItemType(int typeId)
        {
            return await _context.ItemTypes.FirstOrDefaultAsync(x => x.TypeId == typeId);
        }

        /// <summary>
        /// Gets a list of all Item Types
        /// </summary>
        /// <returns>List of ItemTypes</returns>
        public async Task<List<ItemType>> GetItemTypes()
        {
            return await _context.ItemTypes.ToListAsync();
        }
    }
}
