using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//implement a function to reverse a string
//1. use strinbuffer to read the string from the end to beginning
namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string value = args[0];

            StringBuilder sb = new StringBuilder(value.Length);

            for (int i = 1; i <= value.Length; i++)
            {
                sb.Append(value[value.Length - i]);
            }

            Console.WriteLine("{0}", sb);

        }
    }
}
