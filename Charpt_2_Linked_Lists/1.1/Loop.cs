using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
//write cod to remove duplicates from an unsorted linked list
//using 2 loops to remove duplicates
namespace TestSinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<string> ll = new Node<string>("bb");
            
            Node<string>.appendToTail(ll,"aa");
            
            Node<string>.appendToTail(ll,"cc");
            Node<string>.appendToTail(ll,"bb");
            Node<string>.appendToTail(ll,"aa");
            Node<string>.appendToTail(ll,"zz");
            Node<string>.appendToTail(ll,"aa");
            Node<string>.appendToTail(ll,"tt");
            Node<string>.appendToTail(ll,"ss");
            Node<string>.appendToTail(ll,"ff");
            Node<string>.appendToTail(ll,"gg");
            Node<string>.appendToTail(ll,"xx");
            Node<string>.appendToTail(ll,"aa");

            ll = RemoveDuplicateWithLoop<string>(ll);

            Console.WriteLine(ll.ToString());
            Console.Read();

        }

        public static Node<T> RemoveDuplicateWithLoop<T>(Node<T> head)
        {
            Node<T> outerLoop = head;

            while (outerLoop != null)
            {
                Node<T> innerLoop = outerLoop;
                while (innerLoop.Next != null)
                {
                    if (EqualityComparer<T>.Default.Equals(outerLoop.Data, innerLoop.Next.Data))
                    {
                        innerLoop.Next = innerLoop.Next.Next;
                    }
                    else
                    {

                        innerLoop = innerLoop.Next;
                    }
                }

                outerLoop = outerLoop.Next;
            }

            return head;
        }

    }
}
