using System;


namespace Tutorials.Service
{
    public class TutorialService
    {

        public void FirstTutorial()
        {
            Console.Clear();

            Console.WriteLine("Seja Bem-Vindo(a) ao tutorial");
            Console.WriteLine("Para voltar na página anterior, basta clicar o número 0 (zero)");
            Console.WriteLine("A Letra i serve para ver o inventário (onde mostra armas, facas, munição, consumiveis e equipamentos)");
            Console.WriteLine("A letra S é para visualizar os status, como: Vida, nivel, atributos, créditos e implantes");
            Console.WriteLine("A letra E serve para você equipar ou trocar de armas");
            Console.WriteLine("Use ENTER para avançar diálogos e mensagens");

            Console.WriteLine("Para voltar, pressione (o) ");
            Console.WriteLine("");
            Console.ReadKey();
        }

        

    }
}
