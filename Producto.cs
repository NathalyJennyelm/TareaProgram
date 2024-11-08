using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaInventario
{
    public class Producto
    {
        // Propiedades para almacenar el nombre y precio del producto
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        // Constructor que inicializa el nombre y el precio del producto
        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        // Método para mostrar la información del producto en consola
        public void MostrarInformacion()
        {
            Console.WriteLine($"Producto: {Nombre}, Precio: {Precio:C}");
        }
    }
    
}

