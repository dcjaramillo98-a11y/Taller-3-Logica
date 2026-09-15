using Ejercicio35;
using Shared;

int number = ConsoleHelper.ReadInt("Ingrese el número a descomponer: ");

var factorization = new NumberFactorization(number);
Console.WriteLine(factorization);
