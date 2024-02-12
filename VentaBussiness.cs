using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;

namespace ProyectoFinalCoderhouseIriazabal
{
    internal static class VentaBussiness
    {
        public static List<Venta> ListarVentas()
        {
            return VentaData.ListarVentas();
        }
    }
}
