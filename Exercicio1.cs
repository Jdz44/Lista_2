using System;
using MinhaBiblioteca;

class Exercicio1
{
     static int getMin(int[,] matriz)
    {
    int menor = matriz[0, 0];
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for(int i = 0; i < linhas; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if(menor > matriz[i,j])
                    menor = matriz[i,j];
            }//fim do for j
        }//fim do for i
            return menor;
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

            Console.WriteLine("-----MENOR-----");

            Console.WriteLine(getMin(matriz));
            
        }     
}