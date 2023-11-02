using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.ModeloEntrada;
using Servicio.Repositorio;

namespace BFFPruebaFallos2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaDeServicioController : Controller
    {
        public readonly EmpresaDeServicioRepositorio empresaDeServicioRepositorio;

        private readonly ILogger<EmpresaDeServicioController> _logger;

        public EmpresaDeServicioController(ILogger<EmpresaDeServicioController> logger)
        {
            _logger = logger;
            empresaDeServicioRepositorio = new EmpresaDeServicioRepositorio();
        }

        [HttpGet]
        public async Task<List<EmpresaPagoDeServicioEntidad>> GetComprasCliente()
        {
            var clientes = await empresaDeServicioRepositorio.ConsultarEmpresas();
            return clientes;
        }
    }
}
