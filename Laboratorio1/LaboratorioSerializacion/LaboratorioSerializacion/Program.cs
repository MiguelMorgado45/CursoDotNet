namespace LaboratorioSerializacion
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido al almacen de productos");
            
            MostrarMenu();

            Console.WriteLine("Gracias! Vuelve pronto.");

        }

        static void MostrarMenu()
        {
            bool salir = false;
            while (!salir)
            {
                var productos = ListaProductos.ObtenerProductos();

                if (productos.Count > 0)
                    Console.WriteLine($"\nActualmente cuenta con: {productos.Count} producto(s)");
                else
                    Console.WriteLine("\nAún no has agregado ningún producto.");
                Console.WriteLine("A. Registrar Producto");
                Console.WriteLine("B. Listar Productos");
                Console.WriteLine("C. Modificar Producto");
                Console.WriteLine("D. Eliminar Producto");
                Console.WriteLine("Cualquier otra tecla cerrara el programa.\n");

                switch (Console.ReadLine())
                {
                    case "A":
                        Registrar();
                        break;
                    case "B":
                        Consultar();
                        break;
                    case "C":
                        Modificar();
                        break;
                    case "D":
                        Eliminar();
                        break;
                    default:
                        salir = true;
                        break;
                }

            }
        }

        static void Registrar()
        {
            Console.WriteLine("Nuevo producto");

            var productoNuevo = PreguntarProducto();

            ListaProductos.AgregarProducto(productoNuevo);
        }

        static void Consultar()
        {
            var productos = ListaProductos.ObtenerProductos();

            Console.WriteLine("Lista de Productos");
            for (int i = 0; i < productos.Count; i++)
            {
                Console.WriteLine($"{i+1}.- {productos[i]}");
            }
        }

        static void Modificar()
        {
            Console.WriteLine("Modificar producto");

            Consultar();

            Console.WriteLine("Ingresa el número del producto que quieres modificar");

            var posicion = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("No se puede eliminar un número nulo"));
            posicion--;

            if (posicion >= 0)
            {
                var productoNuevo = PreguntarProducto();
                ListaProductos.ModificarProducto(posicion, productoNuevo);
            } else 
                Console.WriteLine("El número debe ser mayor o igual a 1.");
        }

        static void Eliminar()
        {
            Console.WriteLine("Eliminar producto");

            Consultar();

            Console.WriteLine("Ingresa el número del producto que quieres eliminar");

            var posicion = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("No se puede eliminar un número nulo"));
            posicion--;

            if (posicion >= 0)
                ListaProductos.EliminarProducto(posicion);
            else
                Console.WriteLine("El número debe ser mayor o igual a 1.");
        }

        private static Producto PreguntarProducto()
        {
            var productoNuevo = new Producto();

            while (string.IsNullOrEmpty(productoNuevo.Nombre))
            {
                Console.WriteLine("Ingresa el nombre del producto:");
                productoNuevo.Nombre = Console.ReadLine() ?? "";
            }

            while (productoNuevo.Precio <= 0)
            {
                Console.WriteLine("Ingresa el precio del producto:");
                productoNuevo.Precio = float.Parse(Console.ReadLine() ?? "0");
            }

            Console.WriteLine("Ingresa el tipo de producto:");
            Console.WriteLine("1.- Comida");
            Console.WriteLine("2.- Zapatos");
            Console.WriteLine("3.- Playeras");

            productoNuevo.Tipo = (TipoProducto)int.Parse(Console.ReadLine() ?? "0") - 1;

            return productoNuevo;
        }
    }
}