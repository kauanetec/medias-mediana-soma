using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progam_lp
{
    class Program
    {
        static void Main(string[] args)
        {
            int opção;
            double resultado, n1, n2, n3, n4, n5;

            Console.WriteLine("escolha a operação");
            Console.WriteLine("1- media ");
            Console.WriteLine("2- mediana");
            Console.WriteLine("3- soma");
           

            opção = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opção)
            {

                case 1:
                    Console.WriteLine("insira o primeiro numero");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o segundo numero");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o terceiro numero");
                    n3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o quarto numero");
                    n4 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o quinto numero");
                    n5 = Convert.ToDouble(Console.ReadLine());

                    resultado = n1 + n2 + n3 + n4 + n5 /5;
                    Console.Clear();
                    Console.WriteLine(resultado);

                    break;

                case 2:
                    Console.WriteLine("insira o primeiro numero");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o segundo numero");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o terceiro numero");
                    n3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o quarto numero");
                    n4 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o quinto numero");
                    n5 = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                    Console.WriteLine(n4);
                    Console.WriteLine(n5);
                    

                    break;
                case 3:
                    Console.WriteLine("insira o primeiro numero");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o segundo numero");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o terceiro numero");
                    n3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o quarto numero");
                    n4 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("insira o quinto numero");
                    n5 = Convert.ToDouble(Console.ReadLine());

                    resultado = n1 + n2 + n3 + n4 + n5;
                    Console.Clear();
                    Console.WriteLine(resultado);

                    break;
            }

            Console.ReadKey();
        }
    }
}
