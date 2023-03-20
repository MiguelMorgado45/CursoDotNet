Console.WriteLine("Programa de perímetro y área - Miguel Angel Morgado Huerta - Ejercicio B");

var l = 7.0;

// Perímetro
var hipotenusa = Math.Sqrt(Math.Pow(l, 2) + Math.Pow(3 * l, 2));
var perimetroCirculo = (Math.PI * (3 * l)) / 2;
var perimetroRectangulo = (4 * l) + (3 * l);
var perimetro = (2 * hipotenusa) + perimetroRectangulo + perimetroCirculo;

Console.WriteLine($"Perímetro: {Math.Round(perimetro, 4)}");

// Área
double areaCirculo = (3.1416 * Math.Pow(10.5, 2)) / 2;
double areaRectangulo = (3 * l) * l;
double areaTriangulo = ((3 * l) * l) / 2;

var area = areaCirculo + (2 * areaRectangulo) + (2 * areaTriangulo);

Console.WriteLine($"Área: {Math.Round(area, 5)}");