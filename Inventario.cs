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
       
        // Método para actualizar el precio de un producto específico
        public void ActualizarPrecio(string nombre, decimal nuevoPrecio)
        {
            // Busca el producto por nombre (ignora mayúsculas/minúsculas)
            var producto = productos.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (producto != null)
            {
                producto.Precio = nuevoPrecio; // Actualiza el precio si se encuentra
                Console.WriteLine("Precio actualizado.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
    }
}
