using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            try
            {
                Console.Write("Escribe un número: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Escribe otro número: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)
            {
                Console.Write(e.Message);
            }
            catch(FormatException e)
            {
                Console.Write(e.Message);
            }
            Console.ReadKey();
        }
    }
}
