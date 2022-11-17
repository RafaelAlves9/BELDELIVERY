using Microsoft.AspNetCore.Mvc;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreProfileController : ControllerBase
    {
        private readonly IStoreProfileRepositorie _profile;

        public StoreProfileController(IStoreProfileRepositorie profile)
        {
            _profile = profile;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<StoreProfile>>> GetAll()
        {
            List<StoreProfile> StoreProfileById = await _profile.GetAll();
            return Ok(StoreProfileById);
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<ActionResult<StoreProfile>> GetById(int id)
        {
            StoreProfile StoreProfileById = await _profile.GetById(id);
            return Ok(StoreProfileById);
        }

        [HttpPost("create")]
        public async Task<ActionResult<StoreProfile>> Create([FromBody] StoreProfile StoreProfile)
        {

            StoreProfile StoreProfileById = await _profile.Create(StoreProfile);
            return Ok(StoreProfileById);
        }

        [HttpPost("delete/{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            bool StoreProfileById = await _profile.Delete(id);

            return Ok(StoreProfileById);
        }

        [HttpPost("update/{id}")]
        public async Task<ActionResult<StoreProfile>> Update([FromBody] StoreProfile StoreProfile, int id)
        {
            StoreProfile StoreProfileById = await _profile.Update(StoreProfile, id);
            return Ok(StoreProfileById);
        }
    }
}