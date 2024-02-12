using SistemaGestionData;
using SistemaGestionEntities;
using SIstemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCoderhouseIriazabal
{
    public static class ProductoBussiness
    {
        public static List<Producto> ListarProductos()
        {
            return ProductoData.ListarProductos();
        }
    }
}

