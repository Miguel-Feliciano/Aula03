using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar variaveis
            string str;
            int linhas, colunas;
            float[,] matriz;
            float somaDasMedias;
        
            // pedir ao user nº de linhas da matriz
            Console.Write("Insira nº de linhas: ");
            str = Console.ReadLine();
            linhas = int.Parse(str);

            // pedir ao user nº de colunas da matriz
            Console.Write("Insira nº de colunas: ");
            str = Console.ReadLine();
            colunas = int.Parse(str);

            // inicializar a matriz
            matriz = new float[linhas, colunas];

            // pedir ao user os valores float para colocar na matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Insira valor em ({i},{j}): ");
                    str = Console.ReadLine();
                    matriz[i, j] = Convert.ToSingle(str);
                }
            }
            // mostrar matriz e a media para cada linha
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                float soma = 0;
                Console.Write("| ");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                    Console.Write(matriz[i, j] + " ");
                    
                }
                media = soma / matriz.GetLength(1);
                Console.WriteLine($"| -> {media,10:f3}");
                somaDasMedias += media;
            }
            
            // mostrar soma das médias
            Console.WriteLine("Soma das medias: {0,10:f3}", somaDasMedias);
        }
    }
}
