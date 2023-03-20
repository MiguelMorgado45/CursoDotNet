namespace LaboratorioSerializacion
{
    public enum TipoProducto
    {
        Comida,
        Zapatos,
        Playeras,
    }

    [Serializable]
    public class Producto
    {
        public string Nombre { get; set; } = null!;
        public TipoProducto Tipo { get; set; }
        public float Precio { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {Tipo}, Precio: {Precio}";
        }
    }
}
