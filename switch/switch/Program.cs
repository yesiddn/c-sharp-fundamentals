﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Backjack: juntar 21 puntos con las cartas o el número más cercano a 21 sin pasarse para ganar.

int totalJugador = 10;
int totalDealer = 15;
string message = "";
string switchControl = "menu";

switch (switchControl)
{
  case "menu":
    Console.WriteLine("Bienvenido al casino");
    Console.WriteLine("Escriba '21' para jugar");
    switchControl = Console.ReadLine();
    break;

  case "21":
    if (totalJugador > 15 && totalJugador < 22)
    {
      message = "Venciste al dealer, felicidades";
    }
    else if (totalJugador > 21)
    {
      message = "Te pasaste de 21, perdiste";
    }
    else if (totalJugador <= totalDealer)
    {
      message = "Perdiste contra el dealer";
    }
    else
    {
      message = "Error en el juego";
    }
    break;

  default:
    message = "Valor no valido";
    break;
}

Console.WriteLine(message);
