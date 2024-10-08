﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Backjack: juntar 21 puntos con las cartas o el número más cercano a 21 sin pasarse para ganar.

int totalJugador = 0;
int totalDealer = 0;
int num = 0;
string message = "";
string anotherCard = "";
string switchControl = "menu";
System.Random random = new System.Random();

while (true)
{
  totalDealer = 0;
  totalJugador = 0;

  switch (switchControl)
  {
    case "menu":
      Console.WriteLine("Bienvenido al casino");
      Console.WriteLine("Escriba '21' para jugar");
      switchControl = Console.ReadLine();
      break;

    case "21":
      do
      {
        num = random.Next(1, 12);
        totalJugador += num;
        Console.WriteLine("Toma tu carta");
        Console.WriteLine($"Carta con el número {num}");
        Console.WriteLine($"Total: {totalJugador}");

        Console.WriteLine("¿Deseas otra carta? (si/no)");

        anotherCard = Console.ReadLine().ToLower();
      }
      while (anotherCard == "si");

      totalDealer = random.Next(12, 23);

      Console.WriteLine($"Total dealer: {totalDealer}");
      Console.WriteLine($"Tu total: {totalJugador}");

      if (totalJugador > 15 && totalJugador < 22)
      {
        message = "Venciste al dealer, felicidades";
        switchControl = "menu";
      }
      else if (totalJugador > 21)
      {
        message = "Te pasaste de 21, perdiste";
        switchControl = "menu";
      }
      else if (totalJugador <= totalDealer)
      {
        message = "Perdiste contra el dealer";
        switchControl = "menu";
      }
      else
      {
        message = "Error en el juego";
        switchControl = "menu";
      }
      break;

    default:
      message = "Valor no valido";
      break;
  }

  Console.WriteLine(message);
}
