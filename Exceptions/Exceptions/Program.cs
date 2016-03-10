using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Divide 10 by ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10/{0} = {1}", num, (10 / num));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cant't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                //throw new InvalidOperationException("Operation Failed", ex);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
