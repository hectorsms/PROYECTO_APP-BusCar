using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROYECTO_APP_BusCar.DOMAIN.Core.Entities;
using PROYECTO_APP_BusCar.DOMAIN.Core.Interfaces;

namespace APP_BusCar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentoController : ControllerBase
    {
        private readonly IDocumentoRepository _documentoRepository;

        public DocumentoController(IDocumentoRepository documentoRepository)
        {
            _documentoRepository = documentoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var documentos = await _documentoRepository.GetDocumentos();
            return Ok(documentos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDocumentoById(int id)
        {
            var documento = await _documentoRepository.GetDocumento(id);
            return Ok(documento);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Documento documento)
        {
            var result = await _documentoRepository.Insert(documento);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Documento documento)
        {
            if (id != documento.IdDocumento)
                return BadRequest();

            var result = await _documentoRepository.Update(documento);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _documentoRepository.Delete(id);
            return Ok(result);
        }

    }
}