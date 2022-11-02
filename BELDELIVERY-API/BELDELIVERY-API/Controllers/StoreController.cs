using Microsoft.AspNetCore.Mvc;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreRepositorie _store;

        public StoreController(IStoreRepositorie store)
        {
            _store = store;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<Store>>> GetAll()
        {
            List<Store> stores = await _store.GetAll();
            return Ok(stores);
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<ActionResult<Store>> GetById(int id)
        {
            Store store = await _store.GetById(id);
            return Ok(store);
        }

        [HttpPost("create")]
        public async Task<ActionResult<Store>> Create([FromBody] Store store)
        {
            Store Store = await _store.Create(store);
            return Ok(Store);
        }

        [HttpPost("delete/{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            bool store = await _store.Delete(id);
            return Ok(store);
        }

        [HttpPost("update/{id}")]
        public async Task<ActionResult<Store>> Update([FromBody] Store store, int id)
        {
            Store Store = await _store.Update(store, id);
            return Ok(Store);
        }
    }
}