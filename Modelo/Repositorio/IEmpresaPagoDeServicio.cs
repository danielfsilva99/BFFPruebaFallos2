using Modelo.ModeloEntrada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorio
{
    public interface IEmpresaPagoDeServicio
    {
        Task<List<EmpresaPagoDeServicioEntidad>> ConsultarEmpresas();
    }
}
