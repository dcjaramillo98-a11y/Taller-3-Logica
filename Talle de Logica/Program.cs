using TallerLogica;

// Exercise 30 — Operaciones en una Matriz
Console.Write("Ingrese orden de la matriz: ");
int order = int.Parse(Console.ReadLine()!);

var matrix = new SquareMatrix(order);
matrix.Print();

Console.WriteLine($"La sumatoria es: {matrix.GetSum()}");
Console.WriteLine($"El valor máximo es: {matrix.GetMax()}");
Console.WriteLine($"El valor mínimo es: {matrix.GetMin()}");

// Exercise 35 — Descomposición en Factores
Console.Write("Ingrese el número a descomponer: ");
int number = int.Parse(Console.ReadLine()!);

var factorization = new NumberFactorization(number);
Console.WriteLine(factorization);