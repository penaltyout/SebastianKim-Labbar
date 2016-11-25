using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging01
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            double x = 1;

            Console.Write("1 / x : ? ");
            line = Console.ReadLine();

            try
            {
                x = Convert.ToDouble(line);
                x = 1 / x;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("1 / x = " + x.ToString());
            Console.ReadKey();
        }
    }
}
