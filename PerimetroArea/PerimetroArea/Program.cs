Console.WriteLine("Programa de perímetro y área - Miguel Angel Morgado Huerta - Ejercicio B");

var l = 7;

// Perímetro
var hipotenusa = Math.Sqrt(Math.Pow(l, 2) + Math.Pow(3 * l, 2));
var perimetroCirculo = (Math.PI * (3 * l)) / 2;
var perimetroRectangulo = (4 * l) + (3 * l);
var perimetro = (2 * hipotenusa) + perimetroRectangulo + perimetroCirculo;

Console.WriteLine($"Perímetro: {perimetro}");

// Área
var areaCirculo = (Math.PI * Math.Pow(1.5 * l, 2)) / 2;
var areaRectangulo = (3 * l) * l;
var areaTriangulo = ((3 * l) * l) / 2;

var area = areaCirculo + (2 * areaRectangulo) + (2 * areaTriangulo);

Console.WriteLine($"Área: {area}");