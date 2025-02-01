using System;
using System.Collections.Concurrent;

namespace CShh
{
    public class Sortd
    {
        public static void PrintFArray(int[] arr)
        {
            Console.Write("{ ");
            foreach (int num in arr)
            {
                Console.Write(num + " "); // and this was mostly tabbed in VS lmao, Rapid Application Development mos def rn
            }
            Console.Write(" }\n");
        }

        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                { break; } // opt time
            }
        }

        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot2d = Partition(arr, low, high);

                QuickSort(arr, low, pivot2d - 1);
                QuickSort(arr, pivot2d + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot3d = arr[high]; // all right el

            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot3d)
                {
                    i++; // post inc by gorillaz
                    // and swap arri and arrj via temp
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    // or the good ol'
                    //arr[i] = arr[i] ^ arr[j];
                    //arr[j] = arr[i] ^ arr[j];
                    //arr[i] = arr[i] ^ arr[j];
                    // which produced { 4 8 15 16 0 42  } lmao
                }
            }

            int swapTemp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swapTemp;

            return i + 1;
        }
    }
}