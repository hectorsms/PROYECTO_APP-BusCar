using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROYECTO_APP_BusCar.DOMAIN.Core.Interfaces;
using PROYECTO_APP_BusCar.DOMAIN.Infrastructure.Data;

namespace PROYECTO_APP_BusCar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrigenControllers : ControllerBase
    {
        private readonly IOrigenRepository _IOrigenRepository;

        public OrigenControllers(IOrigenRepository origenRepository)
        {
            _IOrigenRepository = origenRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var origen = await _IOrigenRepository.GetOrigen();
            return Ok(origen);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrigenById(int id)
        {
            var Origen = await _IOrigenRepository.GetOrigen(id);
            return Ok(Origen);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Origen Origen)
        {
            var result = await _IOrigenRepository.Insert(Origen);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Origen Origen)
        {
            if (id != Origen.IdOrigen)
                return BadRequest();

            var result = await _IOrigenRepository.Update(Origen);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _IOrigenRepository.Delete(id);
            return Ok(result);
        }

    }
}
