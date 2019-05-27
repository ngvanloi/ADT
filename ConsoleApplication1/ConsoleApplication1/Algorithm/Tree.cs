using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.DataStructure
{
    public class Tree
    {
        #region Tree 1
       
        NodeTree Root_Tree1;
        void Add(int value)
        {
            var node = new NodeTree();
            node.Data = value;
            if (Root_Tree1 == null)
            {
                Root_Tree1 = node;
            }
            else
            {
                Add(Root_Tree1, node);
            }
        }
        void Add(NodeTree parent, NodeTree node)
        {
            if (node.Data < parent.Data)
            {
                if (parent.Left == null)
                {
                    parent.Left = node;
                }
                else
                {
                    Add(parent.Left, node);
                }
            }
            else if(node.Data > parent.Data){
                if (parent.Right == null)
                {
                    parent.Right = node;
                }
                else
                {
                    Add(parent.Right, node);
                }
            }
        }
        #endregion

        #region Tree 2
        NodeTree Root_Tree2;
        int Height()
        {
            if (Root_Tree2 == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(Height(Root_Tree2.Left), Height( Root_Tree2.Right));
            }
        }

        int Height(NodeTree node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(Height(node.Left), Height(node.Right));
            }
        }
        #endregion
    }
}
