using System;
using System.Diagnostics;
using Tutorials.Service;

namespace RpgConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            TutorialService tutorialService = new TutorialService();

            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("1 - Começar");
            Console.Writes("R: ");

            int opcaoMenu = int.Parse(Console.ReadLine() ?? "");

            switch (opcaoMenu)
            {
                case 1:
                    Console.WriteLine("Deseja ver o tutorial antes de começar?");
                    Console.Write("S/N: ");
                    string tutorial = Console.ReadLine() ?? "";

                    if (tutorial == "S")
                    {
                        tutorialService.FirstTutorial();
                    } else if (tutorial == "N")
                    {
                        
                    } else
                    {
                        Console.WriteLine("Resposta inválida, tente novamente.");
                        break;
                    }


                break;
            }
        }
    }
}