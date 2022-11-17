using Microsoft.AspNetCore.Mvc;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreAddressController : ControllerBase
    {
        private readonly IStoreAddressRepositorie _address;

        public StoreAddressController(IStoreAddressRepositorie address)
        {
            _address = address;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<StoreAddress>>> GetAll()
        {
            List<StoreAddress> clientById = await _address.GetAll();
            return Ok(clientById);
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<ActionResult<StoreAddress>> GetById(int id)
        {
            StoreAddress clientById = await _address.GetById(id);
            return Ok(clientById);
        }

        [HttpPost("create")]
        public async Task<ActionResult<StoreAddress>> Create([FromBody] StoreAddress client)
        {

            StoreAddress clientById = await _address.Create(client);
            return Ok(clientById);
        }

        [HttpPost("delete/{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            bool clientById = await _address.Delete(id);

            return Ok(clientById);
        }

        [HttpPost("update/{id}")]
        public async Task<ActionResult<StoreAddress>> Update([FromBody] StoreAddress client, int id)
        {
            StoreAddress clientById = await _address.Update(client, id);
            return Ok(clientById);
        }
    }
}