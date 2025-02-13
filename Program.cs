using System;

namespace buscaBinaria
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O algoritmo irá advinhar um número de 1 a 10 no menor número de passos possíveis");
            Console.WriteLine("Pense em um número nesse intervalo");

            BuscaBinaria();
        }

        static void BuscaBinaria()
        {
            short repetir = 1;
            while (repetir == 1)
            {
                int[] vetor = new int[1000];

                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = i + 1;
                }

                int inicial = vetor[0];
                int final = vetor.Length - 1;

                int media = (inicial + final) / 2;
                Console.WriteLine("-----------------");
                Console.WriteLine($"Numero:{media}");
                Console.WriteLine("Esse é o número correto ? (1) sim / (2) nao");
                short numeroCorreto = short.Parse(Console.ReadLine());

                if (numeroCorreto != 1 && numeroCorreto != 2)
                {

                    Console.WriteLine("Opção Inválida, tente novamente ...");
                    Console.ReadKey();
                    Console.Clear();
                    BuscaBinaria();
                }

                if (numeroCorreto == 1)
                {
                    Console.WriteLine("Numero encontrado!");
                }
                else
                {
                    short r = 2;

                    while (r == 2)
                    {
                        Console.WriteLine("O numero que está pensando é (1) maior ou (2) menor ?");
                        short numeroMaiorMenor = short.Parse(Console.ReadLine());
                        if (numeroMaiorMenor == 1)
                        {
                            inicial = media + 1;
                            media = (inicial + final) / 2;
                            Console.Clear();
                            Console.WriteLine(media);

                        }
                        else
                        {
                            final = media - 1;
                            media = (inicial + final) / 2;
                            Console.Clear();
                            Console.WriteLine(media);
                        }
                        Console.WriteLine("Este é o numero certo ? (1) sim (2) nao ");
                        r = short.Parse(Console.ReadLine());

                    }
                }
                Console.WriteLine("Número encontrado, gostaria de realizar o teste novamente ? (1) sim (2) não");
                repetir = short.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Programa finalizado....");
        }
    }
}