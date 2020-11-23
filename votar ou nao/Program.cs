using System;

namespace votar_ou_nao
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).
            Console.WriteLine("Em que ano estamos?");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano que voce nasceu");
            int nascimento = int.Parse(Console.ReadLine());
            if(ano - nascimento >=18){
                Console.WriteLine("Pode votar");
            } else {
                Console.WriteLine("Não pode votar");
            }
        }
    }
}
