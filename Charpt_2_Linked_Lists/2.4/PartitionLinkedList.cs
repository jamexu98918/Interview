using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

/*
 * Write code to partition a linked list around a value x, 
 * such that all nodes less than x come before all nodes greater than of equal to x.
 * 
 * 1. set 3 list, smaller, equal and great than the value x.
 * 2. go through the linked list. 
 * 3. put every node into approperity list
 * 4. merge the 3 lists from smaller->equal->great
 */
namespace ConsoleApplication1
{
    class PartitionLinkedList
    {
        static void Main(string[] args)
        {
            Node<string> ll = new Node<string>("bb");



            Node<string>.appendToTail(ll, "cc");
            Node<string>.appendToTail(ll, "bb");

            Node<string>.appendToTail(ll, "zz");

            Node<string>.appendToTail(ll, "tt");
            Node<string>.appendToTail(ll, "ss");
            Node<string>.appendToTail(ll, "ff");
            Node<string>.appendToTail(ll, "gg");
            Node<string>.appendToTail(ll, "xx");


            Console.WriteLine(ll.ToString());

            ll=PartitionList<string>(ll, "ii");
            Console.WriteLine(ll.ToString());


            Console.Read();
        }

        public static Node<T> PartitionList<T>(Node<T> head, T value) where T: IComparable
        {
            Node<T> smallList = null;
            Node<T> equallist = null;
            Node<T> greatlist = null;
            Node<T> smalllist_Current = null;
            Node<T> equallist_Current = null;
            Node<T> greatlist_Current = null;
            Node<T> Current = head;

            while (Current != null)
            {
                if (Current.Data.CompareTo(value) < 0)
                {
                    if (smallList == null)
                    {
                        smallList = Current;
                    }
                    else
                    {
                        smalllist_Current.Next = Current;
                    }
                    smalllist_Current = Current;
                }
                else if (Current.Data.CompareTo(value) == 0)
                {
                    if (equallist == null)
                    {
                        equallist = Current;
                    }
                    else
                    {
                        equallist_Current.Next = Current;
                    }
                    equallist_Current = Current;
                }
                else
                {
                    if (greatlist == null)
                    {
                        greatlist = Current;
                    }
                    else
                    {
                        greatlist_Current.Next = Current;
                    }
                    greatlist_Current = Current;
                }

                Current = Current.Next;
            }

            head = smallList;

            if (equallist != null)
            {
                if (head == null)
                {
                    head = equallist;
                }
                else
                {
                    smalllist_Current.Next = equallist;
                }

                equallist_Current.Next = null;
            }

            if (greatlist != null)
            {
                if (head == null)
                {
                    head = greatlist;
                }
                else
                {
                    if (equallist == null)
                    {
                        smalllist_Current.Next = greatlist;
                    }
                    else
                    {
                        equallist_Current.Next = greatlist;
                    }
                }
                greatlist_Current.Next = null;
            }


            return head;
        }
    }
}
