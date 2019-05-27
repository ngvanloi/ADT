using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Stack
    {
        // Last-in , first-out
    #region ArrayList
        int[] Buf;
        int Top = 0;
        public Stack(int size)
        {
            Buf = new int[size];
            Top = -1;
           
        }
        void PushArray(int value) 
        {
            if (Top > Buf.Length)
            {
                Buf[Top++] = value;
                Top++;
            }
            else
            {
                Console.WriteLine("Overflow");
            }
        }
        string PopArray()
        {
            if (Top != -1)
            {
                int n = Buf[Top];
                Top--;
                return n.ToString();
            }
            return "Underflow";
        }
        string PeekArray() 
        {
            if (Top != -1)
            {
                int n = Buf[Top];
                return n.ToString();
            }
            return "Underflow";
        }
        void ClearArray()
        {
            Top = -1;
        }
        int CountArray()
        {
            return Top + 1;
        }

    #endregion

    #region Linklist
        Node TopNode = null;
        void PushLinkedList(int value)
        {
            var n = new Node();
            n.Data = value;
            n.Next = TopNode;
            TopNode = n;
        }

        string PopLinkedList()
        {
            if (TopNode != null)
            {
                var n = TopNode.Data;
                TopNode = TopNode.Next;
                return n.ToString();
            }
            return "Underflow";
        }

        string PeekLinkedList()
        {
            if (TopNode != null)
            {
                var n = TopNode.Data;
                return n.ToString();
            }
            return "Underflow";
        }

        void ClearLinkedList()
        {
            TopNode = null;
        }

        int CountLinkedList()
        {
            int n = 0;
            while (TopNode != null)
            {
                TopNode = TopNode.Next;
                n++;
            }
            return n;
        }

    #endregion
    }
}
