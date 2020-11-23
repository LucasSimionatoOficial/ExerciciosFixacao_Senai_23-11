using System;

namespace valores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o menor valor lido.
            
            Console.WriteLine("Insira o 1° valor");
            float valor = float.Parse(Console.ReadLine());
            float maior = valor;
            float menor = valor;

            for (int i = 2; i < 11; i++)
            {
                Console.WriteLine("Insira o "+i+"° valor");
                valor = float.Parse(Console.ReadLine());
                if(valor > maior){
                    maior = valor;
                } else if(valor < menor){
                    menor = valor;
                }
            }
            Console.Write("Maior valor: "+maior+"\nMenor valor: "+menor);
        }
    }
}
