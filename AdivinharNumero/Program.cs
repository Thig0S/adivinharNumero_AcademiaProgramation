using System.ComponentModel;
using System.Security.Cryptography;

int numAleatorio = RandomNumberGenerator.GetInt32(1,101);
int numeroUsuario = 0;
// int dificuldade = 0;

System.Console.WriteLine("--------------------");
System.Console.WriteLine("Bem-vindo ao Jogo de adivinhacao!");
System.Console.WriteLine("--------------------");

while (true)
{
System.Console.Write("\nDigite um numero: ");
numeroUsuario = Convert.ToInt32(Console.ReadLine());

    if(numAleatorio == numeroUsuario)
        {
            System.Console.WriteLine("parabens voce acertou o numero!");
            break;
        }    
    else if(numeroUsuario < numAleatorio)
        {
            System.Console.WriteLine("Numero digitado e MENOR!");
        }
    else
        {
            System.Console.WriteLine("Numero digitado e MAIOR");        
        }
}
System.Console.WriteLine("Obrigado por jogar!");

