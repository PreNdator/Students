using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public abstract class TreeBase<Info>
    {
        public Node root { get; protected set; }
        public class Node
        {
            public float key { get; }
            public Info info { get; set; }
            internal int height { get; set; }
            public Node left { get; set; }
            public Node right { get; set; }
            public Node(float key, Info info)
            {
                this.key = key;
                this.info = info;
                left = null;
                right = null;
                height = 0;
            }
        }

        public abstract void Add(Info info, float key);
    }
    public class SearchTree<Info>:TreeBase<Info>
    {  
        public SearchTree()
        {
            root = null;
        }

    private void recAdd(Node curr, Node add)
        {
            if(curr.key < add.key)
            {
                if (curr.right != null)
                {
                    recAdd(curr.right, add);
                }
                else
                {
                    curr.right = add;
                }
            }
            else
            {
                if (curr.left != null)
                {
                    recAdd(curr.left, add);
                }
                else
                {
                    curr.left = add;
                }
            }
        }

        override public void Add(Info info, float key)
        {
            Node newNode = new Node(key, info);
            if(root!=null)
            {
                recAdd(root, newNode);
            }
            else
            {
                root = newNode;
            }
        }
    }
}
