using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class AVLTree<Info>: TreeBase<Info>
    {
        
       
        public AVLTree()
        {
            root = null;
        }

        private int GetHeight(Node node)
        {
            if (node == null)
                return 0;
            return node.height;
        }
        private int GetBalanceFactor(Node node)
        {
            if (node == null)
                return 0;
            return GetHeight(node.left) - GetHeight(node.right);
        }

        private Node RotateRight(Node node)
        {
            Node left = node.left;
            Node right = left.right;

            left.right = node;
            node.left = right;

            node.height = Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
            left.height = Math.Max(GetHeight(left.left), GetHeight(left.right)) + 1;

            return left;
        }

        private Node RotateLeft(Node node)
        {
            Node right = node.right;
            Node left = right.left;

            right.left = node;
            node.right = left;

            node.height = Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
            right.height = Math.Max(GetHeight(right.left), GetHeight(right.right)) + 1;

            return right;
        }

        private Node BigRotateLeft(Node node)
        {
            node.left = RotateLeft(node.left);
            return RotateRight(node);
        }

        private Node BigRotateRight(Node node)
        {
            node.right = RotateRight(node.right);
            return RotateLeft(node);
        }

        private Node RecursiveAdd(Node curr, Node add)
        {
            if (curr == null)
                return add;

            if (add.key < curr.key)
            {
                curr.left = RecursiveAdd(curr.left, add);
            }
            else
            {
                curr.right = RecursiveAdd(curr.right, add);
            }

            curr.height = 1 + Math.Max(GetHeight(curr.left), GetHeight(curr.right));

            int balanceFactor = GetBalanceFactor(curr);

            if (balanceFactor > 1)
            {
                if (add.key < curr.left.key)
                {
                    return RotateRight(curr);
                }
                else
                {
                    return BigRotateLeft(curr);
                }
            }

            if (balanceFactor < -1)
            {
                if (add.key > curr.right.key)
                {
                    return RotateLeft(curr);
                }
                else
                {
                    return BigRotateRight(curr);
                }
            }

            return curr;
        }

        override public void Add(Info info, float key)
        {
            Node newNode = new Node(key, info);
            root = RecursiveAdd(root, newNode);

        }
    }
}
