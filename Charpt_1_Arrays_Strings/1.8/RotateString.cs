using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given two String s1 and s2, write code to check if s2 is a rotation of s1 using only one call to issubstring
//ie. ("waterbottle"is a rotation of"erbottlewat")
namespace IsRotateString
{
    class RotateString
    {
        static void Main(string[] args)
        {
            string value1 = "waterbottle";
            string value2 = "erbottlewat";

            Console.WriteLine("value 1 : {0}", value1);
            Console.WriteLine("value 2 : {0}", value2);
            Console.WriteLine("is rotate : {0}", IsRotateString(value1,value2));
        }

        static bool IsRotateString(string value1, string value2)
        {
            if (value1.Length != value2.Length)
            {
                return false;
            }

            value1 += value1;
            if (value1.IndexOf(value2) >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
