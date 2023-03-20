using TeresaSA.Compras;

namespace TeresaSA;

public class Compra
{
    public CompraStrategy? CompraStrategy { get; set; } = null;

    public void Comprar(int totalPiezas)
    {
        CompraStrategy?.Comprar(totalPiezas);
    }

}