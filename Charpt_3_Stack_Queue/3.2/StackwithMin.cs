using System;
using Stack;
/*
 * How would you design a stack which, in addition to push and pop, also has a
 * function min which returns the minimum element? push, pop and min should
 * all operate in O9=(1) time.
 */ 
namespace MinStack
{
    public class StackwithMin <T> where T: IComparable
    {
        private Stack<T> primaryStack = new Stack<T>();
        private Stack<T> minStack = new Stack<T>();

        public void push(T item)
        {
            primaryStack.push(item);
            try
            {
                T min = minStack.peek();
                if (min.CompareTo(item) >= 0)
                {
                    minStack.push(item);
                }
            }catch
            {
                minStack.push(item);
            }

        }

        public T pop()
        {
            T item = primaryStack.pop();
            T min = minStack.peek();
            if (item.CompareTo(min) == 0)
            {
                minStack.pop();
            }

            return item;
        }

        public T min()
        {

            T item = minStack.peek();
            return item;
  
        }
    }
}
