using System;

namespace heron
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3, a, p, c;
            Console.WriteLine("Vamos Calcular a área de qualquer triangulo");

             Console.Write("Qual o valor do lado 1 : ");
            l1 = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor do lado 2 : ");
            l2 = double.Parse(Console.ReadLine());
            
            
            Console.Write("Qual o valor do lado 3 : ");
            l3 = double.Parse(Console.ReadLine());
            Console.WriteLine();     
            p= (l1+l2+l3)/2;

            c=p*(p-l1)*(p-l2)*(p-l3);
            a=Math.Sqrt(c);
             Console.WriteLine($"A sua área  é = {Math.Round(a, 2)}");
             Console.WriteLine($"O seu perimetro  é = {(p)}");
            Console.WriteLine();
        }
    }
}
