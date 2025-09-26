    using System;
    using MinhaBiblioteca;

    class Exercicio3
    {
        static int ContOcor(int [,] matriz, int x)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            int cont = 0;

            for(int i = 0; i < linhas; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    if(matriz[i,j] == x)
                        cont++;
                }
            }
            return cont;
        }
        static void Main()
        {
            
            Console.WriteLine("Insira o número de linhas e colunas: ");
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());

            int[,] matriz = new int[i,j];
            Biblioteca.gerarMatriz(matriz);
            Biblioteca.mostrarMatriz(matriz);
            
            Console.WriteLine($"Insira o valor que queira procurar");
            int x = int.Parse(Console.ReadLine());

            int resultado = ContOcor(matriz, x);
            Console.WriteLine($"o numero {x} aprece {resultado} vezes na matriz.");
        }
    }