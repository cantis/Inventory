using InventoryService.data;
using InventoryService.data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.manager;

namespace InventoryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemTypesController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly ItemTypeManager _itemTypeManager;

        public ItemTypesController(DataContext context, ItemTypeManager itemTypeManager)
        {
            _context = context;
            _itemTypeManager = itemTypeManager;
        }

        // GET: api/ItemTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemType>>> GetItemTypes()
        {
            //return await _context.ItemTypes.ToListAsync();
            return await _itemTypeManager.GetItemTypes();
        }

        // GET: api/ItemTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemType>> GetItemType(int id)
        {
            var itemType = await _context.ItemTypes.FindAsync(id);

            if (itemType == null)
            {
                return NotFound();
            }

            return itemType;
        }

        // PUT: api/ItemTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemType(int id, ItemType itemType)
        {
            if (id != itemType.TypeId)
            {
                return BadRequest();
            }

            _context.Entry(itemType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ItemTypes
        [HttpPost]
        public async Task<ActionResult<ItemType>> PostItemType(ItemType itemType)
        {
            _context.ItemTypes.Add(itemType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemType", new { id = itemType.TypeId }, itemType);
        }

        // DELETE: api/ItemTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemType>> DeleteItemType(int id)
        {
            var itemType = await _context.ItemTypes.FindAsync(id);
            if (itemType == null)
            {
                return NotFound();
            }

            _context.ItemTypes.Remove(itemType);
            await _context.SaveChangesAsync();

            return itemType;
        }

        private bool ItemTypeExists(int id)
        {
            return _context.ItemTypes.Any(e => e.TypeId == id);
        }
    }
}
