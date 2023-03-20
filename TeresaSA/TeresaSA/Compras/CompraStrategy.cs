namespace TeresaSA.Compras;

public abstract class CompraStrategy
{
    public abstract float Precio { get; }
    public abstract int UnidadesPorCarro { get; }
    public abstract void Comprar(int numeroPiezas);
}