using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
//implement an algorithm to delete a node in the middle of the singly linked list.
//given only access to that node
namespace DeleteNode
{
    class DeleteNode
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

            Node<string> current = ll;

            for (int i = 0; i < 6; i++)
            {
                current = current.Next;
            }

            DeleteNode<string>(current);

            Console.WriteLine(ll.ToString());

            Console.Read();
        }

        private static void DeleteNode<T>(Node<T> node)
        {
            node.Data = node.Next.Data;
            node.Next = node.Next.Next;
        }
    }
}
