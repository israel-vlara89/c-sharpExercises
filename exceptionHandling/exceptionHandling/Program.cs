using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = null;

            try
            {
                Console.WriteLine(prog.ToString());
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("From ArgumentNullException: " + ex.Message);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("From ArgumentException: " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("From Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally always executes.");
            }
            Console.ReadKey();
        }
    }
}
