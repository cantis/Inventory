using InventoryService.data.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryService.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<ItemType> ItemTypes { get; set; }
    }
}
