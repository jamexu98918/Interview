using System.Text;
using System.Windows;

//replace space in a string with '%20'
//read the string from begin to end, create stringbuild to hold all char
namespace ReplaceSpace
{
    class ReplaceSpace
    {
        static void Main(string[] args)
        {
            string value = args[0];
            StringBuilder sb = new StringBuilder(value.Length);
            
            for (int i = 0,start=-1,end=-1; i < value.Length; i++)
            {
                if (value[i] == ' ')
                {

                    if (start != end)
                    {

                        sb.Append(value.Substring(start+1, end - start));

                    }
                    sb.Append("%20");
                    start = end = i;
                }
                else
                {
                    end++;
                }
            }
            System.Console.WriteLine("{0}", sb);
           
        }
    }
}
