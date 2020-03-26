using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar variáveis
            string str, c;
            //pedir string ao user 
            Console.Write("Insira uma string: ");
            str = Console.ReadLine();
            // pedir carater c ao user
            Console.Write("Insira uma string: ");
            c = Console.ReadLine();
            // percorrer string
            foreach (char cDaStr in str);
            {
                // imprimir carater da string, exceto se for carater c
                if (cDaStr != c[0])
                {
                    Console.Write(cDaStr);
                }
            
            }
            Console.WriteLine();
    
        
        }       
    }
}
