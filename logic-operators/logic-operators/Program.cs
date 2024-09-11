// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//&& -> And 
//|| -> Or
// ! -> Not
// ^ -> Xor

Console.WriteLine("Operadores lógicos");

//bool valor1 = true;
//bool valor2 = true;
//bool valor3 = false;

// otra forma de declarar variables que tengan el mismo tipo de dato es:
var (valor1, valor2, valor3) = (true, true, false);

bool resultAnd = valor1 && valor2;
// true && true = true
// true && false = false
// false && true = false
Console.WriteLine($"AND: {resultAnd}");

bool resultOr = valor1 || valor2;
// true || true = true
// true || false = true
// false || true = true
// false || false = false
Console.WriteLine($"OR: {resultOr}");

bool resultAndOr = valor1 && valor2 || valor3;
// true && true || false = true
Console.WriteLine($"AND OR: {resultAndOr}");

bool resultNot = !valor1; // negación de true -> false
// !true = false
// !false = true
Console.WriteLine($"NOT: {resultNot}");

bool resultXor = valor1 ^ valor3; // valida si son diferentes
Console.WriteLine($"XOR (true, false): {resultXor}");

bool resultXor2 = valor1 ^ valor2;
Console.WriteLine($"XOR (true, true): {resultXor2}");

bool resultXor3 = valor1 ^ valor2 ^ valor3; // = (true ^ true) ^ false = false -> true y true = false y false = false
// hace la validación de los valores de izquierda a derecha
Console.WriteLine($"XOR (true, true, false): {resultXor3}");