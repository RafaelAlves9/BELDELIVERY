using Microsoft.AspNetCore.Mvc;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientAddressController : ControllerBase
    {
        private readonly IClientAddressRepositorie _address;

        public ClientAddressController(IClientAddressRepositorie address)
        {
            _address = address;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<ClientAddress>>> GetAll()
        {
            List<ClientAddress> clientById = await _address.GetAll();
            return Ok(clientById);
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<ActionResult<ClientAddress>> GetById(int id)
        {
            ClientAddress clientById = await _address.GetById(id);
            return Ok(clientById);
        }

        [HttpPost("create")]
        public async Task<ActionResult<ClientAddress>> Create([FromBody] ClientAddress client)
        {

            ClientAddress clientById = await _address.Create(client);
            return Ok(clientById);
        }

        [HttpPost("delete/{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            bool clientById = await _address.Delete(id);

            return Ok(clientById);
        }

        [HttpPost("update/{id}")]
        public async Task<ActionResult<ClientAddress>> Update([FromBody] ClientAddress client, int id)
        {
            ClientAddress clientById = await _address.Update(client, id);
            return Ok(clientById);
        }
    }
}