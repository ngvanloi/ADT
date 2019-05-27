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
            int[] list = { 5, 1, 4, 2, 8 ,7};

            SortADT.BubbleSort(list);
            SortADT.Quicksort(list, 0, list.Length - 1);

            foreach (var item in list)
            {
                Console.Write(item+"\t");
            }
          
        }

    }
}
