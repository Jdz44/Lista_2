using System;
using MinhaBiblioteca;

class Exercicio5
{
    static void diagonalsecundaria(int[,] matriz)
    {
        int n = matriz.GetLength(0);
        Console.WriteLine("Diagonal secundaria"); 
        
        for(int i = 0; i < n; i++)
        {
            Console.Write(matriz[i , n - 1 - i] + " ");
        }
    }
     static void Main()
    {
       
        Console.WriteLine("Coloque a quantidade de linhas e colunas:");
        int linhas = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        if(linhas != cols)
        {
            Console.WriteLine("A matriz tem que ser quadrada!");
            return;
        }

        int[,] matriz = new int [linhas, cols];

        Biblioteca.gerarMatriz(matriz);
        Biblioteca.mostrarMatriz(matriz);

        diagonalsecundaria(matriz);
    }
}