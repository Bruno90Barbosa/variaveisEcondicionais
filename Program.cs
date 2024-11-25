using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace consoleapp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int n1 = 10, n2 = 15, n3 = 45, n4 = 13, n5 = 31;
            float g1 = 12.5f, g2 = 32.3F, g3 = 17.5F, g4 = 74.7F, g5 = 5.6f;

            Console.WriteLine("EXERCICIOS DE VARIAVEIS E CONDICIONAIS");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("NÚMEROS INTEIROS ---------------------");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("NÚMEROS REAIS/FLUTUANTES -------------");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(g1);
            Console.WriteLine(g2);
            Console.WriteLine(g3);
            Console.WriteLine(g4);
            Console.WriteLine(g5);
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");


            if (n1 * n3 + 12 >= n2 + n4 * n5)
            {
                Console.WriteLine("Condição Verdadeira");
            }
            else
            {
                Console.WriteLine("Condição Falsa");
            }

            if (n2 + n3 * n5 == n1 + 52 / 2)
            {
                Console.WriteLine("Condição Verdadeira");
            }
            else
            {
                Console.WriteLine("Condição Falsa");
            }

            Console.WriteLine("");
            Console.WriteLine(n1 * n3 + 12);
            Console.WriteLine(n2 + n4 * n5);
            Console.WriteLine(n2 + n3 * n5);
            Console.WriteLine(n1 + 52 / 2);
            Console.WriteLine("");



            n1 = 452;
            n2 = 5421;
            n3 = 251;
            n4 = 215;
            n5 = 1245;

            g1 = 548.45f;
            g2 = 48.65f;
            g3 = 63.5f;
            g4 = 485.35f;
            g5 = 555.15f;


            Console.WriteLine("");
            Console.WriteLine("**************");
            Console.WriteLine("NOVOS NÚMEROS INTEIROS ---------------");
            Console.WriteLine("**************");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine("");
            Console.WriteLine("**************");
            Console.WriteLine("NOVOS NÚMEROS REAIS/FLUTUANTES -------");
            Console.WriteLine("**************");
            Console.WriteLine(g1);
            Console.WriteLine(g2);
            Console.WriteLine(g3);
            Console.WriteLine(g4);
            Console.WriteLine(g5);
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            if (n1 * n3 + 12 >= n2 + n4 * n5)
            {
                Console.WriteLine("Condição Verdadeira");
            }
            else
            {
                Console.WriteLine("Condição Falsa");
            }

            if (n2 + n3 * n5 != n1 + 52 / 2)
            {
                Console.WriteLine("Condição Verdadeira");
            }
            else
            {
                Console.WriteLine("Condição Falsa");
            }

            Console.WriteLine("");
            Console.WriteLine(n1 * n3 + 12);
            Console.WriteLine(n2 + n4 * n5);
            Console.WriteLine(n2 + n3 * n5);
            Console.WriteLine(n1 + 52 / 2);

            Console.ReadKey();

        }
    }
}
