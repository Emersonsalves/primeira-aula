﻿using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a sua idade?");
            var result = Console.ReadLine();
            // Transformando  o texto que usuário digitou para um tipo númerico

            var userAge = Int32.Parse(result);

            //comparando SE a idade do usuário é maior que 15 E menor que 51            
            if (userAge > 15 && userAge < 51)
            {
               Console.WriteLine("Sim, você tem idade para o Entra21");
            }
            else if (userAge ==14 || userAge Age ==15);
            { 
            Console.WriteLine("Você não têm idade para o Entra21, mas tem para ser menor aprediz");
            { 
            else if (userAge > 51);
            {    
                Console.WriteLine("Não, você não têm idade para o Entra21");
            }

           
        }
    }
}
