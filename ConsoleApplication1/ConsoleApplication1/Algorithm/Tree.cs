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
       
        public static NodeTree Root_Tree;
        public static void Add(int value)
        {
            var node = new NodeTree();
            node.Data = value;
            if (Root_Tree == null)
            {
                Root_Tree = node;
            }
            else
            {
                Add(Root_Tree, node);
            }
        }
        public static void Add(NodeTree parent, NodeTree node)
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
        public static int Height()
        {
            if (Root_Tree == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(Height(Root_Tree.Left), Height( Root_Tree.Right));
            }
        }

        public static int Height(NodeTree node)
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
