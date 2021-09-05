using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor 01: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 02: ");
            double valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 03: ");
            double valor3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 04: ");
            double valor4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 05: ");
            double valor5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 06: ");
            double valor6 = double.Parse(Console.ReadLine());

            int ehPositivo = 0;

            if (valor1 >0.0){
                ehPositivo += 1;
            }
            if(valor2 > 0.0){
              ehPositivo += 1;
            }
             if(valor3 > 0.0){
              ehPositivo += 1;
            }
             if(valor4 > 0.0){
              ehPositivo += 1;
            }
             if(valor5 > 0.0){
              ehPositivo += 1;
            }
             if(valor6 > 0.0){
              ehPositivo += 1;
            }            
            Console.WriteLine(ehPositivo + " valores positivos");
        }
    }
