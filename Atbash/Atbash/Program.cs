using Atbash;
using static System.Console;

WriteLine("Bienvenido al programa de cifrado Atbash");

var salir = false;

while (!salir)
{
    WriteLine("Ingresa la opción que deseas utilizar:");
    WriteLine("1.- Cifrar o descifrar palabra");
    WriteLine("Cualquier otra tecla - Salir");

    var opcion = ReadLine() ?? "";

    switch (opcion)
    {
        case "1":
            Cifrar();
            break;
        default:
            salir = true;
            break;
    }
}

WriteLine("Gracias");

void Cifrar()
{
    WriteLine("Ingresa la palabra para cifrar o descifrar");
    var palabra = Console.ReadLine() ?? "";
    WriteLine($"Resultado: {palabra.AtbashCipher()}");
}
