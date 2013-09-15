using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//determin if a string has all unique characters.
//1. use bit of an int value to indict each char, 
namespace UniqueCharInString
{
    class UniqueCharInString
    {
        static void Main(string[] args)
        {
            int bits=0;
            if (args.Length <= 0)
            {
                return;
            }

            String value = args[0];

            if (value == null)
            {
                return;
            }
            for (int i = 0; i < value.Length; i++)
            {
                int c = (int)value[i];
                int v = 1 << c-1;
                if ((bits & v) == v)
                {
                    Console.WriteLine("it is not a unique char string");
                    return ;
                }
                else
                {
                    bits |= v;

                }
            }

            Console.WriteLine("it is a unique char string");
        }
    }
}
