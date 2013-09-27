using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace Stack
{
    public class Stack<T>
    {
        Node<T> top;

        public T pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            else
            {
                T item = top.Data;
                top = top.Next;
                return item;
            }

        }

        public void push(T item)
        {
            Node<T> t = new Node<T>(item);
            t.Next = top;
            top = t;
        }

        public T peek()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return top.Data;
            
        }

        public int Count()
        {
            
            if (top == null)
            {
                return 0;
            }
            int count = 1;
            Node<T> node = top;
            while (node.Next != null)
            {
                node = node.Next;
                count++;

            }
            return count;
        }
    }

    public class Queue<T>
    {
        Node<T> first, last;

        public void Enqueue(T item)
        {
            if (first == null)
            {
                first = new Node<T>(item);
                last = first;
            }
            else
            {
                last.Next = new Node<T>(item);
                last = last.Next;
            }
        }

        public T Dequeue()
        {
            if (first == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            else
            {
                T item = first.Data;
                first = first.Next;
                return item;
            }

        }
    }

}
