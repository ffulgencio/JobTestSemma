using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobTestSemma.Models;
using JobTestSemma.UnitOfWorks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JobTestSemma.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SocioController : ControllerBase
    {

        private readonly Contexto _contexto;
        private readonly ILogger<SocioController> _logger;
        private UnitOfWork _uow;

        public SocioController(ILogger<SocioController> logger, Contexto db)
        {
            _logger = logger;
            _contexto = db;
            _uow = new UnitOfWork(_contexto);
        }

        [HttpGet]
        //[Route("")]
        public IEnumerable<Socio> Get()
        {
            return _uow.Socios.All();
        }
    }
}
