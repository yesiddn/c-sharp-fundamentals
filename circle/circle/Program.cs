// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var resultado = 0d; // con d le decimos al compilador que es un double, también se puede usar f para float

//const double Pi = 3.1416; // constante -> por convencion deben usar la estructura PascalCase

Console.WriteLine("Bienvenido, calculemos círculos");

// Pi * radio * radio
Console.WriteLine("Ingrese el radio del círculo");
//var radio = Convert.ToDouble(Console.ReadLine()); // esto no es del todo correcto, es mejor inicializar la variable antes de pedirle al usuario que la llene

double radio = Convert.ToDouble(Console.ReadLine());

resultado = Math.PI * radio * radio; // Math.PI es una constante que tiene el valor de PI

Console.WriteLine($"El área del círculo es: {resultado}"); // interpolación de cadenas
