using Rpg.Entities;

namespace Rpg.Repositories
{
    public class InMemItemsRepository
    {
        private readonly List<Item> items = new() 
        {
            new Item {
                Id = Guid.NewGuid(), 
                Name = "Potion",
                Price = 10,
                CreatedDate = DateTimeOffset.UtcNow
            },
            new Item {
                Id = Guid.NewGuid(), 
                Name = "Bronze Shield",
                Price = 15,
                CreatedDate = DateTimeOffset.UtcNow
            },
            new Item {
                Id = Guid.NewGuid(), 
                Name = "Iron sword",
                Price = 20,
                CreatedDate = DateTimeOffset.UtcNow
            }
        };

        public IEnumerable<Item> GetItems() 
        {
            return items;
        }

        public Item GetItem(Guid id) 
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }
    } 
       
}