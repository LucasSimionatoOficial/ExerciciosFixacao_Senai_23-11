using System;

namespace combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
                // Álcool: 
                    // . até 20 litros, desconto de 3% por litro Álcool 
                    // . acima de 20 litros, desconto de 5% por litro 
                // Gasolina: 
                    // . até 20 litros, desconto de 4% por litro Gasolina 
                    // . acima de 20 litros, desconto de 6% por litro
            // Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
            // Dica: utilize switch case e funções/métodos para otimizar o algorítimo.
            string combustivel;
            int litros;
            do {
                Console.WriteLine("Escolha seu combustível \nPara álcool, digite 'A', gasolina digite 'G'");
                combustivel = Console.ReadLine().ToUpper();
                if (combustivel != "A" && combustivel != "G"){
                    Console.WriteLine("Valor inválido");
                }
            } while (combustivel != "A" && combustivel != "G");
            Console.WriteLine("Digite quantos litros");
            litros = int.Parse(Console.ReadLine());
            switch (combustivel){
                case "G":
                    switch (litros){
                        case <=20:
                            Console.WriteLine("O valor e de "+(litros*5.3*0.96)+" reais");
                            break;
                        default:
                            Console.WriteLine("O valor e de "+(litros*5.3*0.94)+" reais");
                            break;}
                    break;
                default:
                    switch (litros)
                    {
                        case <=20:
                            Console.WriteLine("O valor e de "+(litros*4.9*0.97)+" reais");
                            break;
                        default:
                            Console.WriteLine("O valor e de "+(litros*4.9*0.95)+" reais");
                            break;}
                    break;}
        }
    }
}
