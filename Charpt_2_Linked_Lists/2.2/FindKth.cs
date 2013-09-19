using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

//implement an algorithm to find the kth to last element of a singlylinked list
namespace FindKthtoLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<string> ll = new Node<string>("bb");

            Node<string>.appendToTail(ll, "aa");

            Node<string>.appendToTail(ll, "cc");
            Node<string>.appendToTail(ll, "bb");
            Node<string>.appendToTail(ll, "aa");
            Node<string>.appendToTail(ll, "zz");
            Node<string>.appendToTail(ll, "aa");
            Node<string>.appendToTail(ll, "tt");
            Node<string>.appendToTail(ll, "ss");
            Node<string>.appendToTail(ll, "ff");
            Node<string>.appendToTail(ll, "gg");
            Node<string>.appendToTail(ll, "xx");
            Node<string>.appendToTail(ll, "aa");

            Console.WriteLine(ll.ToString());

            Node<string> kth = FindKthtoLast<string>(ll, 8);

            Console.WriteLine("the last 8th node value is {0}",kth.Data);

            kth = FindKthtoLast<string>(ll, 1);

            Console.WriteLine("the last 1st node value is {0}", kth.Data);

            kth = FindKthtoLast<string>(ll, 15);

            Console.WriteLine("the last 15th node value is {0}", kth.Data);

            Console.Read();
        }

        private static Node<T> FindKthtoLast<T>(Node<T> head, int n)
        {
            Node<T> previous=head;
            Node<T> behind=head;
            int gap=0;
            while (behind.Next != null)
            {
                if (gap < n-1)
                {
                    behind = behind.Next;
                    gap++;
                }
                else
                {
                    behind = behind.Next;
                    previous = previous.Next;
                }
            }
            return previous;
        }
    }
}
