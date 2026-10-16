using System;


Console.WriteLine("MENU PRINCIPAL");
Console.WriteLine("1 - Começar");

int opcao = int.Parse(Console.ReadLine() ?? "");

switch (opcao)
{
    case 1: 
        Console.WriteLine("Deseja ver o tutorial? S/N" );
        string tutorial = Console.ReadLine() ?? "";

    while (true) {
        if (tutorial == "S")
        {
            Console.WriteLine("");
        } else if (tutorial == "N") 
        {
          break;
        }

    }    
    break;
}