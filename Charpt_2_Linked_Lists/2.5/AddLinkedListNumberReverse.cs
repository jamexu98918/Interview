using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
/*
 * You have two numbers represented by a linked list, where each node contains a single digit. 
 * The digits are stored in reverse order, such that the 1's digit is at the head of the list. 
 * Write a function that adds the two numbers and returns the sum as a linked list. 
 * EXAMPLE Input: (7 -> 1 -> 6) + (5 -> 9 -> 2). That is, 617 + 295 Output: 2 -> 1 -> 9. 
 * That is, 912. 
 */
 
namespace AddLinkedlistNumber
{
    class AddLinkedListNumberReverse
    {
        static void Main(string[] args)
        {
            Node<int> a = new Node<int>(7);
            Node<int>.appendToTail(a, 1);
            Node<int>.appendToTail(a, 6);

            Node<int> b = new Node<int>(5);
            Node<int>.appendToTail(b, 9);
            Node<int>.appendToTail(b, 2);
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());

            Node<int> sum = Add(a, b);
            Console.WriteLine(sum.ToString());

            Console.Read();


        }


        static Node<int> Add(Node<int> a, Node<int> b)
        {

            int aint = ConvertNodetoInt(a);
            int bint = ConvertNodetoInt(b);
            int temp = aint + bint;

            return ConvertInttoNode(temp);
        }

        static int ConvertNodetoInt(Node<int> a)
        {
            Node<int> current=a;
            int num=0;
            int count = 0;
            while (current != null)
            {
                int digital = current.Data;
                num += digital * (int)System.Math.Pow(10, count);
                count++;
                current = current.Next;
            }

            return num;
        }

        static Node<int> ConvertInttoNode(int num)
        {
            Node<int> result = null;
            int remainder = 0;
            int amount=num;
            int count = 1;
            do
            {
                remainder = amount % 10;
                amount = amount / 10;
                count++;
                if (result == null)
                {
                    result = new Node<int>(remainder);
                }
                else
                {
                    Node<int>.appendToTail(result, remainder);
                }
            } while (amount > 0);
            
            return result;
        }
    }
}
