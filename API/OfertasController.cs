using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeChip_CadastrosOfertas.Repository.interfaces;

namespace WeChipAPI.Controllers
{
    [ApiController]
    public class OfertasController : ControllerBase
    {
        private readonly IOfertaRepository _ofertaRepository;

        public OfertasController(IOfertaRepository ofertaRepository)
        {
            _ofertaRepository = ofertaRepository;
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public async Task<IActionResult> GetOferta(Guid id)
        {
            try
            {
                var cliente = await this._ofertaRepository.OfertaCompleteAPI(id);
                if (cliente == null) return NotFound(new { error = "Oferta não encontrada" });
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = "Internal Server Error" });
            }
        }

        [HttpGet]
        [Route("api/[controller]/cpf/{cpf}")]
        public async Task<IActionResult> GetOfertaByCPF(string cpf)
        {
            try
            {
                var cliente = await this._ofertaRepository.OfertaCompleteCpfAPI(cpf);
                if (cliente == null) return NotFound(new { error = "Oferta não encontrada" });
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = "Internal Server Error" });
            }
        }
    }
}
