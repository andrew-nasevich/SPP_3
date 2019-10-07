using System;
using System.Collections;
using System.Collections.Generic;

namespace SPP_3
{
    class TreeNode<TNode> : IComparable<TNode>, IEnumerable<TNode>
    where TNode : IComparable
    {
        public TreeNode(TNode value)
        {
            Value = value;
        }

        public TreeNode<TNode> Left { get; set; }
        public TreeNode<TNode> Right { get; set; }
        public TNode Value { get; private set; }

        /// Метод возвращает 1, если значение текущего узла больше,
        /// чем переданного методу, -1, если меньше и 0
        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }

        private IEnumerator<TNode> OutputSymmetrically(TreeNode<TNode> treeNode)
        {

            if (treeNode.Left != null)
            {
                foreach (TNode tn in treeNode.Left)
                {
                    yield return tn;
                }

            }

            yield return treeNode.Value;

            if (treeNode.Right != null)
            {
                foreach (TNode tn in treeNode.Right)
                {
                    yield return tn;
                }
            }
        }

        public IEnumerator<TNode> GetEnumerator()
        {
            return OutputSymmetrically(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return OutputSymmetrically(this);
        }
    }
}
