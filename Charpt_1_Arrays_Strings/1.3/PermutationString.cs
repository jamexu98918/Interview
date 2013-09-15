using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//given two string, write a method to decide if one is a permutation of the other.
//1. convert the string to array
//2. sort the array
//3. compare the char one by one
namespace PermutationString
{
    class PermutationString
    {
        static void Main(string[] args)
        {
            string value1 = args[0];
            string value2 = args[1];

            List<char> list1= value1.ToList<char>();
            list1.Sort();

            List<char> list2 = value2.ToList<char>();
            list2.Sort();

            Console.Write("string 1 is : ");

            foreach (char c in list1)
            {
                Console.Write("{0}", c);
            }

            Console.WriteLine();

            Console.Write("string 2 is : ");

            foreach (char c in list2)
            {
                Console.Write("{0}", c);
            }

            Console.WriteLine();

            if (list1.Count != list2.Count)
            {
                Console.WriteLine("they are not permutation");
                return;
            }

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i])
                {
                    Console.WriteLine("they are not permutation");
                    return;
                }
            }
            Console.WriteLine("they are permutation");
            return;

        }
    }
}
