

using Microsoft.AspNetCore.Mvc;
using Prova_H1.Services;

namespace Prova_H1.Controllers
{
    [ApiController]
    [Route("api/integrante")]
    public class IntegranteController : ControllerBase
    {
        private readonly IIntegranteRepository _integranteRepository;

        public IntergranteController (IIntegranteRepository integranteRepository)
        {
            _integranteRepository = integranteRepository;
        }
       
        [HttpGet]

        public IActionResult OlaIntegrante()
        {
            return Ok("Ola");
        }

        [HttpGet]
        [Route("ObterPorNome")]

        public  IIntegranteRepository obterIntegranteporNome(string nome)
        {
            var integrantePesquisado = _integranteRepository.obterdobterIntegranteporNomea(nome);

            if (integrantePesquisado is null)
                return NotFound($"Integrante chamado >{nome}< não encontrado.");

            return Ok(integrantePesquisado);

        }


    }
}
