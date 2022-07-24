using BiruliroIpsum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace BiruliroIpsum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MitadasController : ControllerBase
    {
        private readonly ILogger<MitadasController> logger;
        private readonly IMitadasService mitadasService;

        public MitadasController(ILogger<MitadasController> logger, IMitadasService mitadasService)
        {
            this.logger = logger;
            this.mitadasService = mitadasService;
        }

        [HttpGet]
        public Mitada Get(int numeroParagrafos)
        {
            return mitadasService.GerarMitada(numeroParagrafos);
        }
    }
}
