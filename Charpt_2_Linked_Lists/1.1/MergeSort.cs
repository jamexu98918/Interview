using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
//write cod to remove duplicates from an unsorted linked list
//1. sort linked list with merge sort method
//2. remove duplicated
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

            ll = RemoveDuplicateWithMergeSort<string>(ll);

            Console.WriteLine(ll.ToString());
            Console.Read();

        }


        public static Node<T> RemoveDuplicateWithMergeSort<T>(Node<T> head) where T : IComparable
        {

            Node<T> newlist= MSort<T>(head);

            Node<T> current = newlist;
            while (current.Next != null)
            {
                if (current.Data.CompareTo(current.Next.Data) == 0)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }

            return newlist;

        }

        private static Node<T> MSort<T>(Node<T> head) where T : IComparable
        {

            int length = GetLength<T>(head);
            Node<T> newHead = null;
            if (length > 1)
            {
                int step = length / 2;

                Node<T> first = head;
                Node<T> second = splitList<T>(head, step);
                first = MSort<T>(first);
                second = MSort<T>(second);
                newHead = Merge<T>(first, second);
            }
            else
                newHead= head;

            return newHead;
        }

        private static Node<T> splitList<T>(Node<T> _head, int _num)
        {
            Node<T> nextHead = null;
            if (_head != null)
            {
                Node<T> nextnode = null;
                nextnode = _head;
                while (nextnode != null && _num > 1)
                {
                    nextnode = nextnode.Next;
                    _num--;
                }

                if (nextnode != null)
                {
                    nextHead = nextnode.Next;
                    nextnode.Next = null;
                }
            }

            return nextHead;
        }

        private static Node<T> Merge<T>(Node<T> first, Node<T> second) where T : IComparable
        {
            Node<T> currentFirst = first;
            Node<T> currentSecond = second;
            Node<T> listHead = null;
            Node<T> listLast = null;
            Node<T> addedNode = null;


            while ((currentFirst != null) && (currentSecond != null))
            {
                int result = currentFirst.Data.CompareTo(currentSecond.Data);
                if (result < 0)
                {
                    addedNode = currentFirst;
                    currentFirst = currentFirst.Next;

                }
                else if (result == 0)
                {
                    addedNode = currentFirst;
                    currentFirst = currentFirst.Next;

                }
                else
                {
                    addedNode = currentSecond;
                    currentSecond = currentSecond.Next;

                }

                if (listLast == null)
                {
                    listHead = addedNode;
                    listLast = addedNode;
                }
                else
                {
                    listLast.Next = addedNode;
                    listLast = addedNode;
                }

            }
            if (currentFirst != null)
            {
                if (listLast == null)
                {
                    listHead = first;
                }
                else
                {
                    listLast.Next = currentFirst;
                }

            }

            if (currentSecond != null)
            {
                listLast.Next = currentSecond;

            }

            return listHead;
        }

        private static int GetLength<T>(Node<T> head)
        {
            int count = 0;
            Node<T> n = head;
            while (n != null)
            {
                n = n.Next;
                count++;
            }

            return count;

        }
    }
}
