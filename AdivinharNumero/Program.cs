using System.ComponentModel;
using System.Security.Cryptography;

int numAleatorio = RandomNumberGenerator.GetInt32(1,101);
int numeroUsuario = 0;
int dificuldade = 0;

System.Console.WriteLine("--------------------");
System.Console.WriteLine("Bem-vindo ao Jogo de adivinhacao!");
System.Console.WriteLine("--------------------");

System.Console.Write("\nDigite um numero: ");
numeroUsuario = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Numero aleatorio: {numAleatorio}");
