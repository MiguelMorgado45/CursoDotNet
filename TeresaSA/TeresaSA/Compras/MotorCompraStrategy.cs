namespace TeresaSA.Compras;

public class MotorCompraStrategy : CompraStrategy
{
    public override float Precio => 20.0f;
    public override int UnidadesPorCarro => 1;

    public override void Comprar(int numeroPiezas)
    {
        float descuento = 0;
        if (numeroPiezas >= 100)
            if (numeroPiezas >= 500)
                descuento = 0.1f;
            else
                descuento = 0.05f;

        var total = numeroPiezas * Precio;
        Console.WriteLine($"Total sin descuento: ${total.ToPesos()}");
        Console.WriteLine($"Total con descuento: ${(total - (total * descuento)).ToPesos()}");
        Console.WriteLine($"Total del descuento: ${(total * descuento).ToPesos()}");
        Console.WriteLine($"Total de autos posibles a armar: {numeroPiezas / UnidadesPorCarro}");
    }
}