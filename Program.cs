using SistemaInventario;
using System;


namespace SistemaInventario
{
    public class Program
    {
        public static void Main()
        {
            Inventario inventario = new Inventario();

            while (true)
            {
                // Menú de opciones para el usuario
                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Actualizar precio de un producto");
                Console.WriteLine("3. Eliminar un producto");
                Console.WriteLine("4. Filtrar y ordenar productos por precio");
                Console.WriteLine("5. Contar y clasificar productos");
                Console.WriteLine("6. Generar reporte resumido");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");

                // Valida la opción ingresada
                if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 1 || opcion > 7)
                {
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    continue;
                }

            }

        }
    }
}