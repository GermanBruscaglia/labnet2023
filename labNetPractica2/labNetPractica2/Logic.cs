using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    public class Logic 
    {
        public static string LanzarException (int num1, int num2)
        {
            try
            {
                double division = num1 / num2;
                return $"{division}";
            }
            catch (DivideByZeroException ex)
            {
                return $"Mensaje de la excepcion: {ex.Message}. Tipo de excepcion: {{ex.GetType()}}";
                throw ex;
            }
        }

        public static int Sumar(int num1, int num2)
        {
            try
            {
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    throw new NumeroCeroException();
                }
            }
            catch(NumeroCeroException ex)
            {
                //Se que esto no corresponde pero no llegue a hacerlo de otra forma.
                Console.WriteLine(ex.Message);
                return 0;
            }

        }
    }
}
