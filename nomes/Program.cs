using System;

namespace nomes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.
            string[] nomes = new string[10];
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um nome");
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine("Digite o nome que quer pesquisar");
            string busca = Console.ReadLine();
            for (var i = 0; i < 10; i++)
            {
                if(nomes[i] == busca){
                    Console.WriteLine("Achei");
                    break;
                } else if (i == 9) {
                    Console.WriteLine("Não achei");
                }
            }
        }
    }
}
