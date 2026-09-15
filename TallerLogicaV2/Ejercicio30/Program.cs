using Ejercicio30;
using Shared;

int order = ConsoleHelper.ReadInt("Ingrese orden de la matriz: ");

var matrix = new SquareMatrix(order);
matrix.Print();

Console.WriteLine($"La sumatoria es: {matrix.GetSum()}");
Console.WriteLine($"El valor máximo es: {matrix.GetMax()}");
Console.WriteLine($"El valor mínimo es: {matrix.GetMin()}");
