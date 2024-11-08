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

        // Método para eliminar un producto de la lista por su nombre
        public void EliminarProducto(string nombre)
        {
            var producto = productos.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (producto != null)
            {
                productos.Remove(producto); // Elimina el producto si se encuentra
                Console.WriteLine("Producto eliminado.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        // Método para filtrar y ordenar productos cuyo precio es mayor a un valor dado
        public void FiltrarYOrdenar(decimal precioMinimo)
        {
            var productosFiltrados = productos.Where(p => p.Precio > precioMinimo)
                                              .OrderBy(p => p.Precio);


            Console.WriteLine("Productos filtrados y ordenados:");
            foreach (var producto in productosFiltrados)
            {
                producto.MostrarInformacion();
            }
        }

        // Método para contar y clasificar productos en rangos de precios
        public void ContarYClasificarProductos()
        {
            var rango1 = productos.Count(p => p.Precio < 100); // Menores a 100
            var rango2 = productos.Count(p => p.Precio >= 100 && p.Precio <= 500); // Entre 100 y 500
            var rango3 = productos.Count(p => p.Precio > 500); // Mayores a 500

            Console.WriteLine($"Productos con precio < 100: {rango1}");
            Console.WriteLine($"Productos con precio entre 100 y 500: {rango2}");
            Console.WriteLine($"Productos con precio > 500: {rango3}");
        }
    }
}
