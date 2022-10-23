using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROYECTO_APP_BusCar.DOMAIN.Core.Entities;
using PROYECTO_APP_BusCar.DOMAIN.Core.Interfaces;

namespace APP_BusCar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalControllers : ControllerBase
    {
        private readonly IPersonalRepository _IPersonalRepository;

        public PersonalControllers(IPersonalRepository personalRepository)
        {
            _IPersonalRepository = personalRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Personal = await _IPersonalRepository.GetPersonal();
            return Ok(Personal);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonalById(int id)
        {
            var Personal = await _IPersonalRepository.GetPersonal(id);
            return Ok(Personal);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Personal Personal)
        {
            var result = await _IPersonalRepository.Insert(Personal);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Personal Personal)
        {
            if (id != Personal.IdPersonal)
                return BadRequest();

            var result = await _IPersonalRepository.Update(Personal);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _IPersonalRepository.Delete(id);
            return Ok(result);
        }

    }
}