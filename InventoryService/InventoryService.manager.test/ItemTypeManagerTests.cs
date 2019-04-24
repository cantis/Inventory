using InventoryService.data;
using InventoryService.data.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace InventoryService.manager.test
{
    /// <summary>
    /// Tests for the Item Type Manager
    /// </summary>
    [TestClass]
    public class ItemTypeManagerTests
    {
        SqliteConnection _connection;
        DataContext _context;
        ItemTypeManager _manager;

        [TestInitialize]
        public async Task TestInit()
        {
            _connection = new SqliteConnection("DataSource=:memory:");
            _connection.Open();

            var options = new DbContextOptionsBuilder<DataContext>().UseSqlite(_connection).Options;

            _context = new DataContext(options);
            await _context.Database.EnsureCreatedAsync();

            _context.ItemTypes.Add(new ItemType { Description = "Armour", Sort = 1 });
            _context.ItemTypes.Add(new ItemType { Description = "Melee", Sort = 2 });
            _context.ItemTypes.Add(new ItemType { Description = "Ranged", Sort = 3 });
            await _context.SaveChangesAsync();

            _manager = new ItemTypeManager(_context);
        }

        [TestMethod]
        public async Task ItemTypeManager_GetAll_OK()
        {
            // arrange

            // act
            var result = _manager.GetItemTypes();

            // assert
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public async Task ItemTypeManager_GetItem_OK()
        {
            // arrange

            // act
            var result = _manager.GetItemType(2);

            // assert
            Assert.AreEqual("Melee", result.Description);
        }
    }
}
