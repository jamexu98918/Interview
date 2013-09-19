using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
//Given a singly linked list of characters, write a function that returns true if the given list is palindrome

namespace CheckLinkedListPalindrome
{
    class CheckLinkedListPalindrome
    {
        static void Main(string[] args)
        {
            Node<string> ll = new Node<string>("A");
            Node<string>.appendToTail(ll, "B");
            Node<string>.appendToTail(ll, "C");
            Node<string>.appendToTail(ll, "D");
            Node<string>.appendToTail(ll, "C");
            Node<string>.appendToTail(ll, "B");
            Node<string>.appendToTail(ll, "A");
            Console.WriteLine(ll.ToString());

            Node<string>[] templist = PutLinkedListtoArray(ll);

            if (isPalindrome(templist))
            {
                Console.WriteLine("is Palindrome");
            }

            Console.Read();
        }

        private static bool isPalindrome<T>(Node<T>[] templist) where T: IComparable
        {
            int start = 0;
            int end = templist.Length - 1;

            while (start < end)
            {
                if (templist[start++].Data.CompareTo(templist[end--].Data)!=0)
                {
                    return false;
                    
                }

            }
            return true;
        }

        private static Node<T>[] PutLinkedListtoArray<T>(Node<T> head)
        {
            Node<T>[] templist = new Node<T>[GetLength(head)];
            Node<T> current = head;
            int count = 0;
            while (current != null)
            {
                templist[count++] = current;
                current = current.Next;
            }
            
            return templist;

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
