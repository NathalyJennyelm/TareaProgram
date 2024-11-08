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

                // Opción para salir del programa
                if (opcion == 7) break;

                // Ejecuta la opción seleccionada
                switch (opcion)
                {
                    case 1:
                        // Agregar producto
                        Console.Write("Ingrese el nombre del producto: ");
                        string nombre = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(nombre))
                        {
                            Console.WriteLine("El nombre no puede estar vacío.");
                            break;
                        }

                        Console.Write("Ingrese el precio del producto: ");
                        if (!decimal.TryParse(Console.ReadLine(), out decimal precio) || precio <= 0)
                        {
                            Console.WriteLine("Precio no válido. Debe ser un número positivo.");
                            break;
                        }

                        inventario.AgregarProducto(new Producto(nombre, precio));
                        Console.WriteLine("Producto agregado.");
                        break;

                    case 2:
                        // Actualizar precio de un producto
                        Console.Write("Ingrese el nombre del producto a actualizar: ");
                        string nombreActualizar = Console.ReadLine();
                        Console.Write("Ingrese el nuevo precio: ");
                        if (!decimal.TryParse(Console.ReadLine(), out decimal nuevoPrecio) || nuevoPrecio <= 0)
                        {
                            Console.WriteLine("Precio no válido. Debe ser un número positivo.");
                            break;
                        }

                        inventario.ActualizarPrecio(nombreActualizar, nuevoPrecio);
                        break;

                    case 3:
                        // Eliminar un producto
                        Console.Write("Ingrese el nombre del producto a eliminar: ");
                        string nombreEliminar = Console.ReadLine();
                        inventario.EliminarProducto(nombreEliminar);
                        break;

                    case 4:
                        // Filtrar y ordenar productos
                        Console.Write("Ingrese el precio mínimo para filtrar: ");
                        if (!decimal.TryParse(Console.ReadLine(), out decimal precioMin) || precioMin < 0)
                        {
                            Console.WriteLine("Precio mínimo no válido.");
                            break;
                        }

                        inventario.FiltrarYOrdenar(precioMin);
                        break;

                    case 5:
                        // Contar y clasificar productos
                        inventario.ContarYClasificarProductos();
                        break;

                    case 6:
                        // Generar reporte resumido
                        inventario.GenerarReporteResumido();
                        break;

                }




            }
        }
    }
}