using Microsoft.AspNetCore.Mvc;
using Rpg.Entities;
using Rpg.Repositories;

namespace Rpg.Controller
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRepository repository;
        
        public ItemsController() 
        {
            repository = new InMemItemsRepository();
        }

        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }

        [HttpGet("{id}")]
        public Item GetItem(Guid id)
        {
            var item = repository.GetItem(id);
            return item;
        }
    }
}