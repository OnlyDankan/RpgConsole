using System;


namespace incio
{
    public class missoes
    {
        public void missaoUm ()
        {

            Console.WriteLine("*Você está inconsciente e apenas ouve uma voz te chamandpo de fundo");
            Console.WriteLine("*Você acorda e nota que está em um banheiro enquanto toca uma música eletrônica de fundo*");
            Console.WriteLine("*Na sua frente você vê um cara chamando pelo seu nome");
            Console.WriteLine("???: (nome!), (nome!), (nome!). Acorda cara! Oque aconteceu com você?");
            Console.WriteLine("*Você se levanta sem se lembrar de nada*");

            Console.WriteLine("Escolha sua resposta");
            Console.WriteLine("1 - Onde eu estou?");
            Console.WriteLine("2 - *Pegar arma e apontar para o homem*");
            Console.WriteLine("3 - Oque aconteceu?");
            int pergunta1 = int.Parse(Console.ReadLine() ?? "");

            switch (pergunta1)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("???: Como assim cara? Ele te drogou?");
                    Console.WriteLine("*Você fica mais confuso e tenta entender a situação. Você se olha no espelho e se vê vestido em um terno, cabelo arrumado e com uma arma na cintura*");
                    Console.WriteLine("(Você pensa: Porque estou com uma arma? Que merda é essa?)");
                    Console.WriteLine("???: (Nome), você tá maluco, porra?! Você foi executar o alvo, mas ele sumiu daqui. Caralho hein, sabia que não era uma boa ideia fazer isso com seu software desatualizado.");
                    Console.WriteLine("*Você responde: Do que você ta falando, porra?");
                    Console.WriteLine("*O homem desconhecido liga para alguém e fala: Ele deixou o alvo escapar, vou evacuar e vou deixar ele com vocês.*");
                    Console.WriteLine("*O homem desconhecido pega sua arma e deixa o local. Você escuta alguns helicópteros chegando*");
                    Console.WriteLine("Oque você vai fazer?");

                    //(continuação aqui)


                    break;
                    case 2:
                        Console.Clear();
                        
                        Console.WriteLine("Você com tom desesperado pergunta: OQUE VOCÊ FEZ? SE AFASTE ANTES QUE EU ATIRE");
                        Console.WriteLine("*O homem desconhecido da um chute na sua mão e grita: VOCÊ TA MALUCO PORRA?");
                        Console.WriteLine("");
                    break;
            }
        }
    }
}