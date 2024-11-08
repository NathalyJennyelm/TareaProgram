using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    public class Inventario
    {
        // Lista para almacenar los productos
        private List<Producto> productos = new List<Producto>();

        // Método para agregar un producto a la lista
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

    }
}
