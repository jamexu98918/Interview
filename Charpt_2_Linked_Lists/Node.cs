using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        private T data;
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        private Node<T> next = null;
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public Node(T _n)
        {
            this.data = _n;
        }

        public static void appendToTail(Node<T> head,T _value)
        {
            Node<T> end = new Node<T>(_value);

            if (head == null)
            {
                head = end;
            }
            else
            {

                Node<T> n = head;
                while (n.Next != null)
                {
                    n = n.Next;
                }

                n.Next = end;
            }
        }

        public static Node<T> DeleteNode(Node<T> head, T d)
        {
            Node<T> n = head;
            if (EqualityComparer<T>.Default.Equals(n.Data, d))
            {
                head = n.Next;
                return head;
            }

            while (n.Next != null)
            {
                if (EqualityComparer<T>.Default.Equals(n.Next.Data, d))
                {
                    n.Next = n.Next.Next;
                    return head;
                }

                n = n.Next;
            }

            return head;

        }

        public new string ToString()
        {
            Node<T> current=this;
            StringBuilder sb = new StringBuilder();
            while (current != null)
            {
                sb.Append(current.Data);
                sb.Append(",");
                current = current.Next;
            }

            return sb.ToString();
        }


    }
}
