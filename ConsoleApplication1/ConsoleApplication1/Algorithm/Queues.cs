using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.DataStructure
{
    public class QueuesADT
    {
        //first-in, first-out
        #region ArrayList

        static int[] Buf;
        static int FrontArray;
        static int RearArray;
        static int S;
        public QueuesADT(int size)
        {
            Buf = new int[size];
            FrontArray = -1;
            RearArray = -1;
            S = Buf.Length;

        }
        public static void EnqueuesArray(int value)
        {
             if (((RearArray + 1) % S) == FrontArray)
                {
                    Console.WriteLine("Overflow");
                }
            
            else
            {
                if (RearArray == -1)
                {
                    FrontArray = RearArray = 0;
                    Buf[RearArray] = value;
                }
                else
                {
                    RearArray = (RearArray + 1) % S;
                    Buf[RearArray] = value;
                }
            }
        }
        public static string DequeuesArray()
        {
            if (FrontArray == -1 )
            {
                return "Underflow";
            }
            else
            {
                var value = Buf[FrontArray];
                FrontArray = (FrontArray + 1) % S;
                return value.ToString();//sửa ở đây
            }

        }
        public static void ClearArray()
        {
            FrontArray = RearArray = -1;
        }
        public static int CountArray()
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

        public static Node FrontLinkedList = null;
        public static Node RearLinkedList = null;
        public static void EnqueuesLinkedList(int value)
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

        public static string DequeuesLinkedList()
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

        public static void ClearLinkedList()
        {
            FrontLinkedList = RearLinkedList = null;
        }

        public static int CountLinkedList() // Xem lai
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
