﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Programa que calcula el área de un rectangulo
var ladoA = 0.0; // la palabra reservada var se usa para declarar variables locales de tipo implícito por lo que es necesario asignar un valor a la variable
double ladoB;
double area;

Console.WriteLine("Calcula el área de un rectángulo");
Console.WriteLine("Ingresa el valor del lado A");
ladoA = Convert.ToDouble(Console.ReadLine()); // lee un valor desde la consola

Console.WriteLine("Ingresa el valor del lado B");
ladoB = Convert.ToDouble(Console.ReadLine()); // ToInt32 convierte el valor a entero
area = ladoA * ladoB;

Console.WriteLine("El área del rectángulo es: " + area);