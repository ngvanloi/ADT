using ConsoleApplication1.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 5, 1, 4, 2, 8, 7 };

            QueuesADT queues = new QueuesADT(3);
            QueuesADT.EnqueuesLinkedList(5);
            




            Console.WriteLine("Count " + QueuesADT.CountLinkedList());
            

        }

    }
}
