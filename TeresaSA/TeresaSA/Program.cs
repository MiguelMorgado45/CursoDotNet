// See https://aka.ms/new-console-template for more information
/*
using TeresaSA;
using TeresaSA.Compras;

Console.WriteLine(@"
 _____                           __     _   
/__   \___ _ __ ___  ___  __ _  / _\   /_\  
  / /\/ _ \ '__/ _ \/ __|/ _` | \ \   //_\\ 
 / / |  __/ | |  __/\__ \ (_| | _\ \_/  _  \
 \/   \___|_|  \___||___/\__,_| \__(_)_/ \_/
                                            
");

string? opcion;
bool salir = false;

do {
  Console.WriteLine("\n\n ¿Que tipo de compra quieres estimar?");
  Console.WriteLine("1.- Motor");
  Console.WriteLine("2.- Carrocería");
  Console.WriteLine("3.- Llantas");
  Console.WriteLine("4.- Adorno");
  Console.WriteLine("Otra tecla - Salir \n");

  opcion = Console.ReadLine();

  var compra = new Compra();

  switch (opcion)
  {
      case "1":
          compra.CompraStrategy = new MotorCompraStrategy();
          break;
      case "2":
          compra.CompraStrategy = new CarroceriaCompraStrategy();
          break;
      case "3":
          compra.CompraStrategy = new LlantaCompraStrategy();
          break;
      case "4":
          compra.CompraStrategy = new AdornoCompraStrategy();
          break;
      default:
          salir = true;
          break;
      
  }

  if (compra.CompraStrategy is not null)
  {
      Console.WriteLine("Ingresa el número de piezas a comprar: ");

      var totalPiezas = Console.ReadLine();

      compra.Comprar(int.Parse(totalPiezas!));
  }

} while(!salir);


*/

A a = new A();
Console.Write(a.doit(4, 5));

public class A
{
    public string doit(int x, int y)
    {
        return "a";
    }

    public string doit(Int32 x, Int32 y)
    {
        return "b";
    }
}
