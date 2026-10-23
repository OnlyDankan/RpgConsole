using System;
using System.Diagnostics;
using Tutorials.Service;

namespace RpgConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("=====================");
            Console.WriteLine("    DEAD CIRCUIT   ");
            Console.WriteLine("=====================");

            Console.WriteLine("Seja bem-vindo(a) ao Dead Circuit");
            Console.WriteLine("Qual é o seu nome, parceiro? ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine() ?? "Viajante";
            Console.WriteLine($"Seja bem-vindo(a), {nome}");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();

            MenuPrincipal();

        }

        static void MenuPrincipal()

        {
            TutorialService tutorialService = new TutorialService();

            bool jogando = true;

            while (jogando) 
            {

                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1 - Explorar");
                Console.WriteLine("2 - Ver personagem");
                Console.WriteLine("3 - Controles");
                Console.Write("R: ");

                int opcaoMenu = int.Parse(Console.ReadLine() ?? "");

                switch (opcaoMenu)
                {
                    case 1:

                    break;



                    case 2:

                    break;
                    case 3:
                    Console.WriteLine("=== CONTROLES ====");

                    tutorialService.FirstTutorial();
                  

                    break;
                }
            } 
        }
    }
}