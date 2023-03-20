using System.Collections;
using System.Xml.Serialization;

namespace LaboratorioSerializacion
{
    public sealed class ListaProductos
    {
        private const string PathArchivo = @"Productos.xml";

        private static ArrayList? _productos;

        private ListaProductos() { }

        public static ArrayList ObtenerProductos()
        {
            if (_productos == null)
            {
                _productos = LeerLista();
            }
            return _productos!;
        }

        public static void AgregarProducto(Producto producto)
        {
            _productos!.Add(producto);
            SerializarLista(_productos);
        }

        public static void ModificarProducto(int posicion, Producto productoNuevo)
        {
            _productos!.RemoveAt(posicion);
            _productos.Insert(posicion, productoNuevo);
        }

        public static void EliminarProducto(int posicion)
        {
            try
            {
                _productos!.RemoveAt(posicion);
                SerializarLista(_productos);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("No existe ese producto.");
            }
            
        }

        private static void SerializarLista(ArrayList productos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ArrayList), new[] { typeof(Producto) });

            using FileStream stream = File.Create(PathArchivo);

            try
            {
                serializer.Serialize(stream, productos);
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static ArrayList? LeerLista()
        {
            var bitsArchivo = File.ReadAllBytes(PathArchivo);

            var serializer = new XmlSerializer(typeof(ArrayList), new[] { typeof(Producto) });

            using var stream = new MemoryStream(bitsArchivo);

            try
            {
                var productos = serializer.Deserialize(stream) as ArrayList;

                return productos;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
