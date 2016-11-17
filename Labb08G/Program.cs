using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb08G
{
    delegate string StringConcatenator(List<string> stringList);
    delegate float NumberOperator(List<float> floatList);

    class Program
    {
        static string stringMethod(List<string> stringList)
        {
            string sList = String.Join(", ", stringList);
            return sList;
        }

        static float AddMethod(List<float> floatlist)
        {
            float addup = 0;

            foreach (var i in floatlist)
            {
                addup += i;
            }
            return addup;
        }

        static float MultiplyMethod(List<float> floatlist)
        {
            float multi = 1;

            foreach (var j in floatlist)
            {
                multi *= j; 
            }
            return multi;
        }

        static void Main(string[] args)
        {
            StringConcatenator stringDelegateInstance = stringMethod;
            NumberOperator floatDelegateInstance01 = AddMethod;
            NumberOperator floatDelegateInstance02 = MultiplyMethod;

            List<string> wordList = new List<string>
            {
                "Korea",
                "Japan",
                "China",
                "Sweden",
                "Norway",
                "Denmark",
                "Finlan",
                "Peace"
            };

            List<float> numberList = new List<float>
            {
                1.1f,
                2.2f,
                3.3f,
                4.4f,
                5.5f,
                6.6f
            };

            Console.WriteLine(stringDelegateInstance(wordList));
            Console.WriteLine(floatDelegateInstance01(numberList));
            Console.WriteLine(floatDelegateInstance02(numberList));

            Console.ReadKey();
        }
    }
}
