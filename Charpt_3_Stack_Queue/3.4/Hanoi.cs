using System;
using System.Collections.Generic;
//classic problem of the Towers of Hanoi.

namespace hanoi
{
    class Hanoi
    {
        static void Main(string[] args)
        {
            Stack<int> A = new Stack<int>();
            Stack<int> B = new Stack<int>();
            Stack<int> C = new Stack<int>();

            A.Push(8);
            A.Push(7);
            A.Push(6);
            A.Push(5);
            A.Push(4);
            A.Push(3);
            A.Push(2);
            A.Push(1);

            //move 8 disk from tower A to tower C
            Hanoi<int>(8, A, B, C);
            Console.WriteLine("Print A");
            print(A);
            Console.WriteLine("Print B");
            print(B);
            Console.WriteLine("Print C");
            print(C);
            Console.Read();
        }

        public static void Hanoi<T>(int num,Stack<T> A, Stack<T> B, Stack<T> C) where T : IComparable
        {
            if (num == 1)
            {
                T item = A.Pop();
                C.Push(item);
            }
            else
            {
                Hanoi<T>(num - 1, A, C, B);
                T item = A.Pop();
                C.Push(item);
                Hanoi<T>(num - 1, B, A, C);
            }
        }

        private static void print<T>(Stack<T> s)
        {
            try
            {
                while (true)
                {
                    T item = s.Pop();
                    Console.WriteLine("{0}", item.ToString());
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("End");
            }
        }
    }
}
