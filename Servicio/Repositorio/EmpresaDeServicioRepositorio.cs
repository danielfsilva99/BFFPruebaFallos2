using Modelo.ModeloEntrada;
using Modelo.Repositorio;
using Servicio.ContextoConexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicio.ContextoConexion;
using System.Data;
using Dapper;

namespace Servicio.Repositorio
{
    public class EmpresaDeServicioRepositorio : IEmpresaPagoDeServicio
    {
        private ContextoConexionDb contexto;

        public EmpresaDeServicioRepositorio()
        {
            contexto = new ContextoConexionDb();
        }
        public async Task<List<EmpresaPagoDeServicioEntidad>> ConsultarEmpresas()
        {
            using (IDbConnection db = contexto.connection)
            {
                var result = await db.QueryAsync<EmpresaPagoDeServicioEntidad>("ConsultarEmpresaServicio", commandType: CommandType.StoredProcedure);
                List<EmpresaPagoDeServicioEntidad> empresa = result.ToList();

                return empresa;
            }
        }
    }
}
