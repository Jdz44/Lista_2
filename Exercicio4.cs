using System;
using MinhaBiblioteca;

class Exercicio4
{
    static void Main()
    {
        Console.WriteLine("Insira a ordem da matriz até 100: ");
        int n = int.Parse(Console.ReadLine());
        if(n > 100 || n <= 0)
        {
            Console.WriteLine("Erro: Esta ordem é invalida!");
            return;
        }
        int [,] matriz = new int [n,n];

        Console.WriteLine("Digite o elemento da matriz: ");
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i,j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\n A diagonal principal dessa matriz");
        for(int i = 0; i < n; i++)
        {
            Console.Write(matriz[i,i] + " ");
        }
    }
}