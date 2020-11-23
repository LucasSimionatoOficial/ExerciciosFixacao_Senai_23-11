using System;

namespace numerosinvertidos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi declarado.
            float[] numeros = new float[15];
            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite o "+(i+1)+"° número");
                numeros[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Números ao contrario");
            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine(numeros[14-i]);
            }
        }
    }
}
