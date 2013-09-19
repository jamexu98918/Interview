using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
/*
 * Given a circular linked list, implement an algorithm which returns node at the beginning of the loop.
 * DEFINITION
 * Circular linked list:
 * A (corrupt) linked list in which a node’s next pointer points to an earlier node, so as to make a loop in the linked list.
 * EXAMPLE
 * input: A -> B -> C -> D -> E -> C [the same C as earlier]
 * output: C
 */
namespace FindLinkedListCircleStart
{
    class FindCircleStart
    {
        static void Main(string[] args)
        {
            Node<string> ll = new Node<string>("A");

            Node<string>.appendToTail(ll, "B");

            Node<string>.appendToTail(ll, "C");
            Node<string>.appendToTail(ll, "D");
            Node<string>.appendToTail(ll, "E");
            Console.WriteLine(ll.ToString());
            Node<string> loopstart = FindLoopStart<string>(ll);

            if (loopstart == null)
            {
                Console.WriteLine("No loop");
            }

            Node<string> c = GetNode<string>(ll,"C");
            Node<string> e = GetNode<string>(ll,"E");

            e.Next = c;
            Console.WriteLine("created loop");
            loopstart = FindLoopStart<string>(ll);
            if (loopstart != null)
            {
                Console.WriteLine("{0}", loopstart.Data);
            }
            
            Console.Read();
        }

        static Node<T> FindLoopStart<T>(Node<T> head)
        {
            Node<T> slow = head;
            Node<T> fast = head;
            bool loop=false;

            while (slow != null && fast != null)
            {
                if (slow == fast && slow != head)
                {
                    loop = true;
                    break;
                }
                slow = slow.Next;
                if (fast.Next != null)
                {
                    fast = fast.Next.Next;
                }
                else
                {
                    fast = null;
                }
                
            }

            if (loop)
            {
                slow = head;
                while (slow != fast)
                {
                    slow = slow.Next;
                    fast = fast.Next;
                }

                return slow;
            }

            return null;
        }

        static Node<T> GetNode<T>(Node<T> head,T value) where T: IComparable
        {
            Node<T> current=head;
            while (current != null)
            {
                if (current.Data.CompareTo(value) == 0)
                {
                    return current;
                }
                current = current.Next;
            }

            return null;
        }
    }
}
