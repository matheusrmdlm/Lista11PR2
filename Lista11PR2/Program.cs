using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11PR2
{
    internal class Program
    {
        public static void Exec1()
        {
            int[] numeros = new int[1000];


            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i + 1;
            }

            Console.WriteLine("Tente adivinhar um número de 1 a 1000:");

            while (true)
            {
                int palpite = int.Parse(Console.ReadLine());

                if (Array.Exists(numeros, numero => numero == palpite))
                {
                    Console.WriteLine("Parabéns! Você acertou.");
                    break;
                }
                else
                {
                    Console.WriteLine("Número incorreto. Tente novamente:");
                }
            }
        }
        public static void Exec2()
        {
            int[] numeros = new int[20000];


            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i % 100;
            }

            Console.WriteLine("Digite um número para verificar quantas vezes ele aparece no vetor:");
            int numeroEscolhido = int.Parse(Console.ReadLine());

            int contador = 0;

            foreach (int numero in numeros)
            {
                if (numero == numeroEscolhido)
                {
                    contador++;
                }
            }

            Console.WriteLine($"O número {numeroEscolhido} aparece {contador} vezes no vetor.");

        }
        public static void Exec3()
        {
            int[] vetorOriginal = new int[10];
            int[] vetorModificado = new int[10];

            Console.WriteLine("Digite 10 números inteiros e positivos:");

            for (int i = 0; i < vetorOriginal.Length; i++)
            {
                vetorOriginal[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetorOriginal.Length; i++)
            {
                if (i % 2 == 0) 
                {
                    vetorModificado[i] = vetorOriginal[i] / 2;
                }
                else 
                {
                    vetorModificado[i] = vetorOriginal[i] * 3;
                }
            }

            Console.WriteLine("Vetor original:");
            for (int i = 0; i < vetorOriginal.Length; i++)
            {
                Console.Write(vetorOriginal[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Vetor modificado:");
            for (int i = 0; i < vetorModificado.Length; i++)
            {
                Console.Write(vetorModificado[i] + " ");
            }
            Console.WriteLine();

        }
        public static void Exec4()
        {
            int[] numeros = new int[5000];

            Console.WriteLine("Digite 5000 números:");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Números primos encontrados:");

            for (int i = 0; i < numeros.Length; i++)
            {
                int divisor = 2;
                int ehPrimo = 1;

                if (numeros[i] < 2)
                {
                    ehPrimo = 0;
                }
                else
                {
                    while (divisor <= Math.Sqrt(numeros[i]))
                    {
                        if (numeros[i] % divisor == 0)
                        {
                            ehPrimo = 0;
                            break;
                        }
                        divisor++;
                    }
                }

                if (ehPrimo == 1)
                {
                    Console.WriteLine($"{numeros[i]} é primo.");
                }
                else
                {
                    Console.WriteLine($"{numeros[i]} não é primo.");
                }
            }
        }
        static void Main(string[] args)
        {
            int exec;
            do
            {
                Console.WriteLine("     menu");
                Console.WriteLine("exercicio 1");
                Console.WriteLine("exercicio 2");
                Console.WriteLine("exercicio 3");
                Console.WriteLine("exercicio 4");
                Console.WriteLine("Digite 0 para fechar o programa");
                exec = int.Parse(Console.ReadLine());

                switch (exec)
                {
                    case 1:
                        Exec1();
                        break;
                    case 2:
                        Exec2();
                        break;
                    case 3:
                        Exec3();
                        break;
                    case 4:
                        Exec4();
                        break;
                }
            }while(exec!=0);
        }
    }
}
