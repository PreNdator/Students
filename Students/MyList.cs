using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class MyList<T>
    {
        public class Node
        {
            public T info { get; set; }
            public Node next { get; set; }
            public Node prev { get; set; }
            public Node(T info)
            {
                this.info = info;
                next = null; 
                prev = null;
            }
        }
        public int count { get; private set; }
        public Node first { get; private set; }
        public Node last { get; private set; }
        public MyList()
        {
            first = null;
            last = null;
        }

        
        public bool Delete(Node node)
        {
            if (node == null)
                return false;

            if (node.prev != null)
                node.prev.next = node.next;
            else
                first = node.next;

            if (node.next != null)
                node.next.prev = node.prev;
            else
                last = node.prev;

            --count;
            return true;
        }

        public bool AddAfter(Node node, T info)
        {
            if (node == null)
                return false;

            Node newNode = new Node(info);

            newNode.next = node.next;
            newNode.prev = node;

            if (node.next != null)
                node.next.prev = newNode;
            else
                last = newNode;

            node.next = newNode;
            ++count;
            return true;
        }

        public bool AddBefore(Node node, T info)
        {
            if (node == null)
                return false;

            Node newNode = new Node(info);

            newNode.prev = node.prev;
            newNode.next = node;

            if (node.prev != null)
                node.prev.next = newNode;
            else
                first = newNode;

            node.prev = newNode;
            ++count;
            return true;
        }

        public void Add(T info)
        {
            if (first != null)
            {
                last.next = new Node(info);
                last.next.prev = last;
                last = last.next;
            }
            else
            {
                first = new Node(info);
                last = first;
            }
            ++count;
        }

    }
}
