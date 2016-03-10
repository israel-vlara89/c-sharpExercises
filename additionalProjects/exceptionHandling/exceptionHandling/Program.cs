using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    class Program
    {
        static void HandleNullReference()
        {
            Program prog = null;

            try
            {
                Console.WriteLine(prog.ToString());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
