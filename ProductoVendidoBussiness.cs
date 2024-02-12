using SIstemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;

namespace ProyectoFinalCoderhouseIriazabal
{
    public static class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> ObtenerProductosVendidos()
        {
            return ProductoVendidoData.ObtenerProductoVendido();
        }
    }
}
