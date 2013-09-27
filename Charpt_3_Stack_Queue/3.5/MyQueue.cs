using System;
using System.Collections.Generic;

//implmenent a MyQueue class which implements a queue using two stacks

namespace MyQueue
{
    public class MyQueue<T>
    {
        private Stack<T> s1 = new Stack<T>();
        private Stack<T> s2 = new Stack<T>();

        public void enqueue(T item)
        {
            MoveStack(s1, s2);
            s1.Push(item);
            MoveStack(s2, s1);
        }

        public T dequeue()
        {
            return s1.Pop();
        }

        private void MoveStack(Stack<T> s1, Stack<T> s2)
        {
            while(s1.Count >0)
            {
                T item = s1.Pop();
                s2.Push(item);
            }
            
        }

    }
}
