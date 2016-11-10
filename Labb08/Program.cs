using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    delegate string StringConcatenatorDelegate(List<string> stringList);
    delegate float NumberOperatorDelegate(List<float> floatList);

    class Program
    {
        static string StringConcatenatorMethod(List<string> stringList)
        {
            string StringConcatenatorString = String.Join(", ", stringList);
            return StringConcatenatorString;
        }

        static float NumberOperatorMethodA(List<float> floatList)
        {
            float addup = 0;

            foreach (var i in floatList)
            {
                addup += i;
            }

            return addup;
        }

        static float NumberOperatorMethodB(List<float> floatList)
        {
            float multiply = 1;

            foreach (var i in floatList)
            {
                multiply *= i;
            }

            return multiply;
        }

        static void Main(string[] args)
        {
            List<string> stringList = new List<string>()
            {
                "AAA",
                "BBB",
                "CCC",
                "DDD",
                "EEE"
            };

            List<float> floatList = new List<float>()
            {
                1.5f,
                2.3f,
                3.4f,
                4.8f,
                5.9f
            };

            StringConcatenatorDelegate dele1 = StringConcatenatorMethod;
            NumberOperatorDelegate dele2 = NumberOperatorMethodA;
            NumberOperatorDelegate dele3 = NumberOperatorMethodB;

            Console.WriteLine(dele1(stringList));
            Console.WriteLine(dele2(floatList));
            Console.WriteLine(dele3(floatList));

            Console.ReadKey();
        }
    }
}
