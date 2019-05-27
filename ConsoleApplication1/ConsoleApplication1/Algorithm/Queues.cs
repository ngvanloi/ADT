using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.DataStructure
{
    public class Queues
    {
        //first-in, first-out
        #region ArrayList

        int[] Buf;
        int FrontArray;
        int RearArray;
        int S;
        public Queues(int size)
        {
            Buf = new int[size];
            FrontArray = -1;
            RearArray = -1;
            S = Buf.Length;

        }
        void EnqueuesArray(int value)
        {
            if (RearArray == -1)
            {
                FrontArray = RearArray = 0;
                Buf[RearArray] = value;
            }
            else
            {
                if (((RearArray + 1) % S) == FrontArray)
                {
                    Console.WriteLine("Overflow");
                }
                else
                {
                    RearArray = (RearArray + 1) % S;
                    Buf[RearArray] = value;
                }
            }
        }
        string DequeuesArray()
        {
            if (FrontArray == -1)
            {
                return "Underflow";
            }
            else
            {
                var value = Buf[FrontArray];
                FrontArray = (FrontArray + 1) % S;
                return Buf[FrontArray].ToString();
            }

        }
        void ClearArray()
        {
            FrontArray = RearArray = -1;
        }
        int CountArray()
        {
            if (FrontArray == -1)
            {
                return 0;
            }
            else
            {
                if (FrontArray <= RearArray)
                {
                    return RearArray - FrontArray + 1;
                }
                else
                {
                    return S - (FrontArray - RearArray + 1);
                }
            }

        }
        #endregion

        #region LinkerList

        Node FrontLinkedList = null;
        Node RearLinkedList = null;
        void EnqueuesLinkedList(int value)
        {
            var n = new Node();
            if (RearLinkedList == null)
            {
                FrontLinkedList = RearLinkedList = n;
            }
            else
            {
                RearLinkedList.Next = n;
                RearLinkedList = n;
            }
        }

        string DequeuesLinkedList()
        {
            if (FrontLinkedList == null)
            {
                return "underflow";
            }
            else
            {
                var n = FrontLinkedList.Data;
                FrontLinkedList = FrontLinkedList.Next;
                if (FrontLinkedList == null)
                {
                    RearLinkedList = null;
                }
                return n.ToString();

            }
        }

        void ClearLinkedList()
        {
            FrontLinkedList = RearLinkedList = null;
        }

        int CountLinkedList() // Xem lai
        {
            int length = 0;
            while (FrontLinkedList != null)
            {
                length++;
                FrontLinkedList = FrontLinkedList.Next;
                if (FrontLinkedList == null)
                {
                    return length;
                }
               

            }
            return 0;
        }
        #endregion

    }
}
