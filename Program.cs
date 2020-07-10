using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            //var currentDate = DateTime.Now;
            
            //Console.WriteLine(currentDate);

            Console.WriteLine("Qual a sua idade?");
            var result = Console.ReadLine();
            
            //Transformando o texto que usuário digitou para um tipo númerico
            int userAge = Int32.Parse(result);

            //comparando SE a idade do usuário é maior que 15 E menor que 51            
            if (userAge > 15 && userAge < 51)
            {
               Console.WriteLine("Sim, você tem idade para o Entra21");
            }
            else if (userAge == 14 || userAge == 15)
            { 
            Console.WriteLine("Você não têm idade para o Entra21, mas têm para ser menor aprediz");
            } 
            else if (userAge > 50)
            {    
            Console.WriteLine("Não, você não têm idade para o Entra21");
            }
            Console.WriteLine("Só isso, mais nada");
           
        }
    }
}
