using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStop.BL
{
    public class ProductoBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Minecraft";
            producto1.Precio = 200; 

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "ARK";
            producto2.Precio = 30.99;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "FIFA";
            producto3.Precio = 25.55;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return listadeProductos;
        }
    }
}
