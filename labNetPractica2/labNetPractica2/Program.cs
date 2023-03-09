using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Ejercicio 1*****");
            Console.WriteLine(Ejercicio1.Division());

            Console.WriteLine("*****Ejercicio 2*****");
            Console.WriteLine(Ejercicio2.Division());

            Console.WriteLine("*****Ejercicio 3*****");
            try
            {
                Console.WriteLine(Logic.LanzarException(10, 0));
            }
            catch 
            {
              
            }
            finally
            {
                Console.WriteLine("fin de la operación");
            }

            Console.WriteLine("*****Ejercicio 4*****");
            Console.WriteLine(Logic.Sumar(10, 0));
            
            Console.Read();
        }
    }
}
