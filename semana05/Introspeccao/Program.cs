using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Criatividade adicionada:
         * 
         * 1. O programa controla as mensagens aleatórias utilizadas
         *    para evitar repetir perguntas até que todas sejam exibidas.
         *
         * 2. O usuário recebe uma experiência mais organizada,
         *    utilizando animações de progresso e contagem regressiva.
         *
         * 3. Foi criado um menu simples para facilitar a navegação
         *    entre as atividades.
         */


        int option = 0;


        while (option != 4)
        {
            Console.Clear();

            Console.WriteLine("Programa de Introspecção");
            Console.WriteLine();
            Console.WriteLine("Escolha uma atividade:");
            Console.WriteLine();
            Console.WriteLine("1. Atividade de Respiração");
            Console.WriteLine("2. Atividade de Reflexão");
            Console.WriteLine("3. Atividade de Listagem");
            Console.WriteLine("4. Sair");
            Console.WriteLine();

            Console.Write("Digite sua escolha: ");

            option = int.Parse(Console.ReadLine());


            switch (option)
            {
                case 1:

                    BreathingActivity breathing = new BreathingActivity();

                    breathing.Run();

                    break;


                case 2:

                    ReflectionActivity reflection = new ReflectionActivity();

                    reflection.Run();

                    break;


                case 3:

                    ListingActivity listing = new ListingActivity();

                    listing.Run();

                    break;


                case 4:

                    Console.WriteLine();
                    Console.WriteLine("Obrigado por usar o Programa de Introspecção!");

                    break;


                default:

                    Console.WriteLine("Opção inválida.");

                    Thread.Sleep(2000);

                    break;
            }
        }
    }
}