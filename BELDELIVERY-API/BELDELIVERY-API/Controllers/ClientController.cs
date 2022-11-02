using Microsoft.AspNetCore.Mvc;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientProfileRepositorie _profile;
        private readonly IClientRepositorie _client;

        public ClientController(IClientRepositorie client)
        {
            _client = client;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<Client>>> GetAll()
        {
            List<Client> clientById = await _client.GetAll();
            return Ok(clientById);
        }

        [HttpGet("login")]
        public async Task<ActionResult<Client>> Login(string email, string password)
        {
            var client = await _client.Login(email, password);

            return Ok(client);
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<ActionResult<Client>> GetById(int id)
        {
            Client clientById = await _client.GetById(id);
            return Ok(clientById);
        }

        [HttpPost("create")]
        public async Task<ActionResult<Client>> Create([FromBody] Client client)
        {

            Client clientById = await _client.Create(client);
            return Ok(clientById);
        }

        [HttpPost("delete/{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            bool clientById = await _client.Delete(id);

            return Ok(clientById);
        }

        [HttpPost("update/{id}")]
        public async Task<ActionResult<Client>> Update([FromBody] Client client, int id)
        {
            Client clientById = await _client.Update(client, id);
            return Ok(clientById);
        }
    }
}