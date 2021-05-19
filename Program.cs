using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular1 = new Celular();

            Console.WriteLine("qual cor você vai querer? temos: Yellow, Blue , Black, Gray e Green");
            string color = Console.ReadLine();

            celular1.tamanho = 15f;

            celular1.modelo = "SANSUNG";

            Console.WriteLine("Digite apenas o seu primero nome");
            string nome = Console.ReadLine();

            Console.WriteLine("aperte 'L' para ligar o celular");
            string ligar_celular = Console.ReadLine().ToUpper();

            if (ligar_celular == "L")
            {
                celular1.Ligado();
            }

                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color, true);
                Console.WriteLine($@"
====================
|_______====_______|
|                  | 
|                  |
|                  |
|                  |
|     SANSUNG      |
|                  |
|  {celular1.tamanho} POLEGADAS    |
|                  |
|==================|
|        ◯         |
|==================|");
            do
            {
                Console.WriteLine($@"
====================
|_______====_______|
|                  | 
| Bem vind@ {nome} |
|                  |
|                  |
| 1-Ligar          |
| 2-Mensagem       |
| 3-desligar       |
|                  |
|==================|
|        ◯         |
|==================|");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine($@"
====================
|_______====_______|
|                  | 
| Lista de contato |
|                  |
| 1-martu          |
| (11)99782-7989   |
| 2-reur           |
| (11)99782-7989   |
|                  |
|==================|
|        ◯         |
|==================|");
                        string opcao_ligacao = Console.ReadLine();
                        switch (opcao_ligacao)
                        {
                            case "1":
                                Console.WriteLine($@"
====================
|_______====_______|
|                  | 
| martu            |
|                  |
| (11)99782-7989   |
|                  |
| {celular1.LigarNumero()}      |
|                  |
|                  |
|==================|
|        ◯         |
|==================|");
                                break;
                            case "2":
                                Console.WriteLine($@"
====================
|_______====_______|
|                  | 
| reur             |
|                  |
| (11)99782-7989   |
|                  |
| {celular1.LigarNumero()}      |
|                  |
|                  |
|==================|
|        ◯         |
|==================|");
                                break;
                            default:
                                break;
                        }

                        break;
                    case "2":
                        Console.WriteLine($@"
====================
|_______====_______|
|                  | 
| whatsapp 😎      |
|                  |
|                  |
| 1-martu          |
| 2-reur           |
|                  |
|                  |
|==================|
|        ◯         |
|==================|");
                        string opcao_mensagem = Console.ReadLine();
                        switch (opcao_mensagem)
                        {
                            case "1":
                                Console.WriteLine($@"
====================
|_______====_______|
| 😎 martu         |
| ---------------- | 
| -eae             |
|             eae- |
|                  |
|                  |
| digite uma       |
| mensagem         |
|==================|
|        ◯         |
|==================|");
                                string escrita = Console.ReadLine();
                                Console.WriteLine($@"
====================
|_______====_______|
| 😎 martu         |
| ---------------- | 
| -eae             |
|             eae- |
|        {escrita}-|
|                  |
| digite uma       |
| mensagem         |
|==================|
|        ◯         |
|==================|");
                                celular1.EnviarMensagem();
                                break;
                            case "2":
                                Console.WriteLine($@"
====================
|_______====_______|
| 🐵 reur          |
| ---------------- | 
| -eae             |
|             eae- |
|                  |
|                  |
| digite uma       |
| mensagem         |
|==================|
|        ◯         |
|==================|");
                                string escrita2 = Console.ReadLine();
                                Console.WriteLine($@"
====================
|_______====_______|
| 🐵 reur          |
| ---------------- | 
| -eae             |
|             eae- |
|       {escrita2}-|
|                  |
| digite uma       |
| mensagem         |
|==================|
|        ◯         |
|==================|");
                                celular1.EnviarMensagem();
                                break;
                            default:
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("desligando o celular");
                        celular1.Desligado();
                     break;
                    default:
                        break;
                }
            } while (celular1.ld == true);
        }
    }
}