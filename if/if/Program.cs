// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Backjack: juntar 21 puntos con las cartas o el número más cercano a 21 sin pasarse para ganar.

int totalJugador = 10;
int totalDealer = 15;
string message = "";

if (totalJugador > 15 && totalJugador < 22)
{
  message = "Venciste al dealer, felicidades";
} else if (totalJugador > 21)
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

Console.WriteLine(message);
