using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class SortADT : Program
    {
        public SortADT() { }

        public static void BubbleSort(int[] list)
        {
            int n = list.Length;
            bool done = false;
            int temp;
            while (!done)
            {
                done = true;
                n = n - 1;
                for (int i = 0; i <= n - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        done = false;
                    }
                }
            }
        }

        public static void SelectionSort(int[] list)
        {
            int n = list.Length;
            int temp;
            int start = 0;
            while (start != n)
            {
                for (int i = start; i < n; i++)
                {
                    if (list[start] > list[i])
                    {
                        temp = list[i];
                        list[i] = list[start];
                        list[start] = temp;
                    }
                }
                start++;
            }
        }
        public static void InsertSort(int[] list)
        {
            int temp, j, n = list.Length;
            for (int i = 1; i < n; i++)
            {
                j = i;
                temp = list[j];
                while (j > 0 && list[j - 1] > temp)
                {
                    list[j] = list[j - 1];
                    j--;
                }
                list[j] = temp;
            }
        }

        public static int[] Quicksort(int[] List, int left, int right)
        {
            int pval, pindex, l = left, r = right, temp;
            bool inorder = true;
            if (l == r)
                return List;
            if (List[l] >= List[l + 1])
                pval = List[l];
            else
                pval = List[l + 1];

            while (l < r)
            {
                while ((List[l] < pval) && (l < r))
                    l++;
                while ((List[r] >= pval) && (l < r))

                    r--;

                if (l != r)
                {
                    temp = List[l];
                    List[l] = List[r];
                    List[r] = temp;
                    inorder = false;
                }
            }
            if (!inorder)
            {
                Quicksort(List, left, l - 1);
                Quicksort(List, l, right);
            }
            return List;

        }


        /////////////////
        // Merge Sort //
        ///////////////
        public static void MergeSort(int[] list,int head,int end)
        {
            if (head <= end)
            {
                int mid = (head + end) / 2;
                MergeSort(list,head,mid);
                MergeSort(list, mid + 1, end);
                Merge(list, head, mid, end);

            }
        }

        public static void Merge(int[] list, int head, int mid, int end)
        {
            int i, j, k;
            int[] Left = null, Right = null;
            int lengthLeft = mid - head + 1;
            int lengthRight = end - mid;
            for (int m  = 0; m < lengthLeft; m++)
            {
                Left[m] = list[m + head];
            }
            for (int n = 0; n < lengthRight; n++)
            {
                Right[n] = list[n + mid];
            }
            i = 0; j = 0; k = head;
            while ((i < lengthLeft) && (j < lengthRight))
            {
                if (Left[i] < Right[j])
                {
                    list[k] = Left[i];
                    i++;
                }
                else
                {
                    list[k] = Right[j];
                    j++;
                }
                k++;
            }
            while (i < lengthLeft)
            {
                list[k] = Left[i];
                i++;
                k++;
            }
            while (j < lengthRight)
            {
                list[k] = Right[j];
                j++;
                k++;
            }
        }

        /////////////////
        // Merge Sort //
        ///////////////

    }
}
