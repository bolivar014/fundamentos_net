// Importamos nugget humanizer
using Humanizer;

Console.WriteLine("Por favor ingrese su nombre");
// Leemos
var nombre = Console.ReadLine();

Console.WriteLine("Por favor ingrese su cargo");
var cargo = Console.ReadLine();

Console.WriteLine("Ingrese su edad");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Mi nombre es: {nombre}, trabajo como: {cargo} y tengo: {edad.ToWords(new System.Globalization.CultureInfo("es"))} años");