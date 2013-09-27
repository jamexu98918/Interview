using System;
using System.Text;
using System.Collections.Generic;
/*
 * Describe how you could use a single array to implement three stacks
 */ 
namespace ThreeStackwithArray 
{
    public class ThreeStackwithArry<T>
    {
        public enum StackID { First = 1, Second, Third };

        private T[] array;
        private int first, last, middle;
        private int stackLength;

        public int StackLength
        {
            get { return stackLength; }
            set { stackLength = value; }
        }

        public ThreeStackwithArry(int length)
        {
            if (length < 1)
            {
                throw new ArgumentException("Each stack size must bigger than 0");
            }
            array = new T[length*3];
            first = -1;
            last = length*3;
            middle = length-1;
            stackLength = length;
        }

        public void push(StackID stackid,T item)
        {
            switch (stackid)
            {
                case StackID.First:
                    if (first == this.StackLength-1)
                    {
                        throw new IndexOutOfRangeException("First Stack is full");
                    }

                    array[++first] = item;
                    break;
                case StackID.Second:
                    if (middle == (this.StackLength*2-1))
                    {
                        throw new IndexOutOfRangeException("Second Stack is full");
                    }
                    array[++middle] = item;
                    break;
                case StackID.Third:
                    if (last == (this.StackLength*2))
                    {
                        throw new IndexOutOfRangeException("Third Stack is full");
                    }
                    array[--last] = item;
                    break;
            }
        }

        public T pop(StackID stackid)
        {
            T item = default(T);
            switch (stackid)
            {
                case StackID.First:
                    if (first <0)
                    {
                        throw new IndexOutOfRangeException("First Stack is empty");
                    }

                    item = array[first--];
                    break;
                case StackID.Second:
                    if (middle == (this.StackLength-1))
                    {
                        throw new IndexOutOfRangeException("Second Stack is empty");
                    }
                    item = array[middle--];
                    break;
                case StackID.Third:
                    if (last == (this.StackLength * 3))
                    {
                        throw new IndexOutOfRangeException("Third Stack is empty");
                    }
                    item = array[last++];
                    break;
            }

            return item;
        }

    }
}
