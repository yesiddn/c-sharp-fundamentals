// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

var (valor1, valor2) = (10, 5);

Console.WriteLine("Los valores son: " + valor1 + valor2);

// Operadores relacionales
// == igual a
// != diferente de
// > mayor que
// < menor que
// >= mayor o igual que
// <= menor o igual que

bool resultIgual = valor1 == valor2;
Console.WriteLine("==: " + resultIgual);

bool resultDiferente = valor1 != valor2;
Console.WriteLine("!=: " + resultDiferente);

bool resultMayor = valor1 > valor2;
Console.WriteLine(">: " + resultMayor);

bool resultMenor = valor1 < valor2;
Console.WriteLine("<: " + resultMenor);

bool resultMayorIgual = valor1 >= valor2;
Console.WriteLine(">=: " + resultMayorIgual);

bool resultMenorIgual = valor1 <= valor2;
Console.WriteLine("<=: " + resultMenorIgual);
