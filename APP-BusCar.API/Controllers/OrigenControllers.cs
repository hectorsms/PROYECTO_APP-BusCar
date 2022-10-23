using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROYECTO_APP_BusCar.DOMAIN.Core.Entities;
using PROYECTO_APP_BusCar.DOMAIN.Core.Interfaces;

namespace APP_BusCar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrigenControllers : ControllerBase
    {
        private readonly IOrigenRepository _OrigenRepository;

        public OrigenControllers(IOrigenRepository origenRepository)
        {
            _OrigenRepository = origenRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var origen = await _OrigenRepository.GetOrigen();
            return Ok(origen);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrigenById(int id)
        {
            var Origen = await _OrigenRepository.GetOrigen(id);
            return Ok(Origen);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Origen Origen)
        {
            var result = await _OrigenRepository.Insert(Origen);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Origen Origen)
        {
            if (id != Origen.IdOrigen)
                return BadRequest();

            var result = await _OrigenRepository.Update(Origen);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _OrigenRepository.Delete(id);
            return Ok(result);
        }

    }
}