using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10. Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.
            for (var i = 1; i < 11; i++)
            {
                for (var j = 1; j < 11; j++)
                {
                    Console.WriteLine(i+"x"+j+"="+(i*j));
                }
                Console.WriteLine("");
            }
        }
    }
}
