using System;

namespace Problema02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1, num2;
                byte result;

                num1 = 30;
                num2 = 60;
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
                Console.ReadLine();
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("El resultado supera lo que puede ser representado por un byte");
            }
            
        }
    }
}
