using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//implement a method to perform basic string compression using the counts of repeated charaters.
//for example, the string aabcccccaaa would become a2b1c5a3. 
//if the "compressed" string would not become smaller than the original string, your method should return the original string.
namespace CompressString
{
    class CompressString
    {
        static void Main(string[] args)
        {
            string value = args[0];

            StringBuilder sb = new StringBuilder(value.Length);

            char current;
            char last = value[0];
            int count = 1;
            for (int i = 1; i < value.Length; i++)
            {
                current = value[i];
                if (current == last)
                {
                    count++;
                }
                else
                {
                    sb.Append(last);
                    sb.Append(count);
                    count = 1;
                    last = current;
                }
            }
            sb.Append(last);
            sb.Append(count);

            if (sb.Length >= value.Length)
            {
                Console.WriteLine("{0}", value);
            }
            else
            {
                Console.WriteLine("{0}", sb);
            }

            Console.ReadLine();
        }
    }
}
