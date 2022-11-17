using Microsoft.AspNetCore.Mvc;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministratorController : ControllerBase
    {
        private readonly IAdministratorRepositorie _admin;

        public AdministratorController(IAdministratorRepositorie admin)
        {
            _admin = admin;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<Administrator>>> GetAll()
        {
            List<Administrator> clientById = await _admin.GetAll();
            return Ok(clientById);
        }

        [HttpGet("login")]
        public async Task<ActionResult<Administrator>> Login(string email, string password)
        {
            var client = await _admin.Login(email, password);

            return Ok(client);
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<ActionResult<Administrator>> GetById(int id)
        {
            Administrator clientById = await _admin.GetById(id);
            return Ok(clientById);
        }

        [HttpPost("create")]
        public async Task<ActionResult<Administrator>> Create([FromBody] Administrator client)
        {

            Administrator clientById = await _admin.Create(client);
            return Ok(clientById);
        }

        [HttpPost("delete/{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            bool clientById = await _admin.Delete(id);

            return Ok(clientById);
        }

        [HttpPost("update/{id}")]
        public async Task<ActionResult<Administrator>> Update([FromBody] Administrator client, int id)
        {
            Administrator clientById = await _admin.Update(client, id);
            return Ok(clientById);
        }
    }
}