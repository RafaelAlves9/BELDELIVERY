using Microsoft.AspNetCore.Mvc;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientProfileController : ControllerBase
    {
        private readonly IClientProfileRepositorie _profile;

        public ClientProfileController(IClientProfileRepositorie profile)
        {
            _profile = profile;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<ClientProfile>>> GetAll()
        {
            List<ClientProfile> clientById = await _profile.GetAll();
            return Ok(clientById);
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<ActionResult<ClientProfile>> GetById(int id)
        {
            ClientProfile clientById = await _profile.GetById(id);
            return Ok(clientById);
        }

        [HttpGet("get-by-idclient/{id}")]
        public async Task<ActionResult<ClientProfile>> GetByIdClient(int id)
        {
            ClientProfile clientById = await _profile.GetByIdClient(id);
            return Ok(clientById);
        }

        [HttpPost("create")]
        public async Task<ActionResult<ClientProfile>> Create([FromBody] ClientProfile client)
        {
            ClientProfile clientById = await _profile.Create(client);
            return Ok(clientById);
        }

        [HttpPost("delete/{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            bool clientById = await _profile.Delete(id);

            return Ok(clientById);
        }

        [HttpPost("update/{id}")]
        public async Task<ActionResult<ClientProfile>> Update([FromBody] ClientProfile client, int id)
        {
            ClientProfile clientById = await _profile.Update(client, id);
            return Ok(clientById);
        }
    }
}