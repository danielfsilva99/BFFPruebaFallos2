using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ModeloEntrada
{
    public class EmpresaPagoDeServicioEntidad
    {
        public int id_empresa_de_servicio { get; set; }
        public string nombre_empresa { get; set; }
        public string descripcion_Servicio { get; set; }
    }
}
