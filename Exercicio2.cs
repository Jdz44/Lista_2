using System;
using MinhaBiblioteca;

class Exercicio2
{
     static int getMin(int[,] matriz)
    {
    int maior = matriz[0, 0];
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for(int i = 0; i < linhas; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if(maior < matriz[i,j])
                    maior = matriz[i,j];
            }//fim do for j
        }//fim do for i
            return maior;
    }
        static void Main()
        {
            int linhas, cols;

            Console.WriteLine("Entre com a quantidade de linhas e colunas: ");
            linhas = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            
            int[,] matriz = new int[linhas,cols];

            Biblioteca.gerarMatriz(matriz);
            Biblioteca.mostrarMatriz(matriz);

            Console.WriteLine("-----MAIOR-----");

            Console.WriteLine(getMin(matriz));
            
        }     
}