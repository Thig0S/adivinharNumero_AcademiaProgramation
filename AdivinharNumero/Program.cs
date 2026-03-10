using System.ComponentModel;
using System.Security.Cryptography;

    while (true) //while pro jogador digitar a dificuldade certa
    {
    int numeroUsuario = 0;
    string? escolherdificuldade;
    int numDificuldade;
    int tentativas;
    int pontos = 1000;

    Console.Clear();

    System.Console.WriteLine("--------------------");
    System.Console.WriteLine("Bem-vindo ao Jogo de adivinhacao!");
    System.Console.WriteLine("--------------------");

    while(true){
    System.Console.WriteLine("\nSelecione a dificuldade do jogo: ");
    System.Console.WriteLine("1 - Numero aleatorio ate 20 - 10 TENTATIVAS!");
    System.Console.WriteLine("2 - Numero aleatorio ate 50 - 5 TENTATIVAS!");
    System.Console.WriteLine("3 - Numero aleatorio ate 100 - 3 TENTATIVAS!");
    System.Console.Write("Dificuldade: ");

    escolherdificuldade = Console.ReadLine();

        switch(escolherdificuldade)
        {
            case "1":
                numDificuldade = 20;
                tentativas = 10;
            break;
            case "2":
                numDificuldade = 50;
                tentativas = 5;
                break;
            case "3":
                numDificuldade = 100;
                tentativas = 3;
                break;
            default:
            Console.Clear();
            System.Console.WriteLine("\nDigite um numero VALIDO!\n");
            continue;
        }
        break;
    }
    int[] numerosDigitados = new int[tentativas]; // declara o array com o numero de tentativas 
    
    Console.Clear();
       int numAleatorio = RandomNumberGenerator.GetInt32(1,numDificuldade);
    for (int i = 1; i <= tentativas; i ++)
    {

    System.Console.WriteLine($"\nTENTATIVA {i} de {tentativas}*");
    System.Console.WriteLine("------------------");
    System.Console.WriteLine($"SUA PONTUACAO E {pontos}");
    System.Console.WriteLine("------------------");
    System.Console.Write($"\nDigite um numero de ate {numDificuldade}: ");
    numeroUsuario = Convert.ToInt32(Console.ReadLine());

    if(numerosDigitados.Contains(numeroUsuario))
        {
            System.Console.WriteLine($"Voce ja digitou o numero {numeroUsuario}");
                i--;
                continue; //volta o loop e decrementa o I para continuar na mesma tentativa
        }
    numerosDigitados[i] = numeroUsuario;

    int diferencaNumerica = Math.Abs(numAleatorio - numeroUsuario);

        if(diferencaNumerica >= 10)
            {
                pontos -= 100;
            }
        else if(diferencaNumerica >= 5)
            {
                pontos -= 50;
            }
        else
            {
                pontos -=20;
            }
        if(numAleatorio == numeroUsuario)
            {
                System.Console.WriteLine("PARABENS voce acertou o numero!");
                System.Console.WriteLine($"SUA PONTUACAO FOI {pontos}");
            }    
        else if(numeroUsuario < numAleatorio)
            {
                System.Console.WriteLine("Numero digitado e MENOR!");
                continue;
            }
        else
            {
                System.Console.WriteLine("Numero digitado e MAIOR");        
                continue;
            }     
        break;
    }
    if(numAleatorio != numeroUsuario)
    {
        System.Console.WriteLine($"\nGAME OVER suas tentativas acabaram o numero secreto era: {numAleatorio}");
    }
    System.Console.Write("\nDeseja jogar novamente? (S/N)");
    if(Console.ReadLine() != "s")
        {
            break;
        }
    }
    System.Console.WriteLine("Obrigado por jogar!");
