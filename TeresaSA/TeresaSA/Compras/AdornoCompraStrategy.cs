﻿namespace TeresaSA.Compras
{
    public class AdornoCompraStrategy : CompraStrategy
    {
        public override float Precio => 1.5f;
        public override int UnidadesPorCarro => 2;
        public override void Comprar(int numeroPiezas)
        {
            var total = numeroPiezas * Precio;
            Console.WriteLine($"Total sin descuento: ${total.ToPesos()}");

            float descuento = 0.0f;

            if (total > 1000)
            {
                int unidadesADescontar = numeroPiezas / 3;
                descuento = Precio * unidadesADescontar;
            }

            Console.WriteLine($"Total con descuento: ${(total - descuento).ToPesos()}");
            Console.WriteLine($"Total del descuento: ${descuento.ToPesos()}");
            Console.WriteLine($"Total de autos posibles a armar: {numeroPiezas / UnidadesPorCarro}");
        }
    }
}
