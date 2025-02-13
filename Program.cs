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
                int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38,
                39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56,
                57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
                75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92,
                93, 94, 95, 96, 97, 98, 99, 100 };

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