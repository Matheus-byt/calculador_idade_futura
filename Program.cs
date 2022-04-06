using System;

namespace Testing
{
    class Cadastro
    {
        static void Main()
        {

            // Calculador de idade e idade futura 2025

            int ano, atual, idade, idadefutura;

            Console.WriteLine("Digite o seu ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual: ");
            atual = int.Parse(Console.ReadLine());

            idade = (atual - ano); 

            idadefutura = (idade + 3);

            Console.WriteLine($"Você hoje tem {idade} anos de idade, e em 2025 você vai ter: {idadefutura} anos de idade. ");



            

        }
    }
}
