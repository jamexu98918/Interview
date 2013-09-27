using System;
using Stack;
using LinkedList;

/* Imagine a (literal) stack of plates. If the stack gets too high, it might topple. 
 * Therefore, in real life, we would likely start a new stack when the previous stack exceeds some threshold. 
 * Implement a data structure SetOfStacks that mimics this. 
 * SetOfStacks should be composed of several stacks and should create a new stack once the previous one exceeds capacity. 
 * SetOfStacks.push() and SetOfStacks.pop() should behave identically to a single stack 
 * (that is, pop() should return the same values as it would if there were just a single stack). 
 * FOLLOW UP 
 * Implement a function popAt(int index) which performs a pop operation on a specific sub-stack. 
 */

namespace SetOfStacks
{
    public class SetOfStacks<T>
    {
        private Node<Stack<T>> stacklist;
        private int capasity;
        private int count;

        public Node<Stack<T>> ActiveStack
        {
            get {
                Node<Stack<T>> node = stacklist;
                while (node.Next != null)
                {
                    node = node.Next;
                }
                return node;
            }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public int Capasity
        {
            get { return capasity; }
            set { capasity = value; }
        }

        public SetOfStacks(int _capacity)
        {
            this.Capasity = _capacity;
            this.Count = 0;

        }

        public void push(T item)
        {
            if (stacklist == null)
            {

                this.stacklist = newStackNode();
            }

            if (this.ActiveStack.Data.Count()==this.Capasity)
            {

                this.ActiveStack.Next = newStackNode();
    
            }
            this.ActiveStack.Data.push(item);
            this.Count++;
        }

        public T pop()
        {
            if (this.Count <= 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T item = popStack(this.ActiveStack);

            return item;
        }

        public T popAt(int index)
        {

            if (index < 1)
            {
                throw new InvalidOperationException("no such stack");
            }
            Node<Stack<T>> node = stacklist;
            for (int i = 1; i < index; i++)
            {
                if (node == null)
                {
                    throw new InvalidOperationException("no such stack");
                }
                node = node.Next;
            }

            T item = popStack(node);

            return item;
        }

        private T popStack(Node<Stack<T>> node)
        {
            T item = node.Data.pop();
            this.Count--;
            if (node.Data.Count() == 0)
            {
                RemoveNode(node);
            }

            return item;
        }

        private void RemoveNode(Node<Stack<T>> node)
        {
            if (stacklist == node)
            {
                stacklist = node.Next;
            }
            else
            {
                Node<Stack<T>> currentNode = stacklist;
                while (currentNode.Next != node)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = node.Next;
            }
        }

        private Node<Stack<T>> newStackNode()
        {
            Stack<T> newStack = new Stack<T>();
            Node<Stack<T>> newNode = new Node<Stack<T>>(newStack);
            newNode.Data = newStack;

            return newNode;
        }
    }

}
