using System;
using System.Collections.Generic;

/*
 * Write a program to sort a stack in ascending order(with biggest items on the top).
 * you may use at most one additional stack to hold items, but you may not copy the elements
 * into any other data structure(such as an array). the stack supports the following operations:
 * push, pop, peek, and isEmpty(or count);
 */ 
namespace SortStack
{
    class SortStack
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(7);
            stack.Push(10);
            stack.Push(1);
            stack.Push(2);
            stack.Push(6);
            stack.Push(3);
            stack.Push(4);
            stack.Push(9);
            stack.Push(10);
            Stack<int> temp = new Stack<int>();

            Sort1<int>(stack);

            //Sort2<int>(stack,temp,1);

            while (stack.Count > 0)
            {
                Console.WriteLine("{0}", stack.Pop());
            }
            Console.WriteLine("End");
            Console.Read();

        }


        public static void Sort1<T>(Stack<T> s) where T : IComparable
        {
            Stack<T> temp = new Stack<T>();
            while (s.Count > 0)
            {
                T sTop = s.Pop();
                while(temp.Count>0 && temp.Peek().CompareTo(sTop)<0)
                {
                    s.Push(temp.Pop());
                }

                temp.Push(sTop);
                
            }

            while (temp.Count > 0)
            {
                s.Push(temp.Pop());
            }

        }


        //sort stack s by temp stack space with specify order, order = 1: ascending, order = -1 : Desending
        public static void Sort2<T>(Stack<T> s, Stack<T> temp,int order) where T : IComparable
        {
            bool isSwitch = false;

            while (s.Count > 0)
            {
                T item = s.Pop();
                if (temp.Count>0)
                {
                    T temptop = temp.Peek();
                    if (temptop.CompareTo(item) * order < 0)
                    {
                        temp.Pop();
                        temp.Push(item);
                        temp.Push(temptop);
                        isSwitch = true;
                    }
                    else
                    {
                        temp.Push(item);
                    }
                }
                else
                {
                    temp.Push(item);
                }
                
            }

            if (isSwitch)
            {
                Sort2<T>(temp, s, order * -1);
            }
            else
            {
                if (order == 1)
                {
                    while (temp.Count > 0)
                    {
                        s.Push(temp.Pop());
                    }
                }
            }


        }
    }
}
