using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_3
{
    public class Tree<T> : IEnumerable<T>
    where T : IComparable
    {
        private TreeNode<T> head;

        public void Add(T value)
        {
            if (head == null)
            {
                head = new TreeNode<T>(value);
            }
            else
            {
                AddRecursively(head, value);
            }
        }

        private void AddRecursively(TreeNode<T> node, T value)
        {
            if (value.CompareTo(node.Value) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode<T>(value);
                }
                else
                {
                    AddRecursively(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new TreeNode<T>(value);
                }
                else
                {
                    AddRecursively(node.Right, value);
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return head.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return head.GetEnumerator();
        }
    }
}
