using System;
using System.Threading;
using System.Threading.Tasks;
using static CShh.MTStuff;
using static CShh.Binz<int>;
using System.Net.WebSockets; // this cannot be the way..

namespace CShh
{ // aaah newline {'s

    class Program
    {

        static string GetFizzier(int number)
        { // ah capital functions nooooo

            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            if (number % 3 == 0)
                return "Fizz";
            if (number % 5 == 0)
                return "Buzz";
            return number.ToString(); // actually forgor this, and the compiler complained... noice.. lmao

        }

        static async Task Main(string[] args)
        { // everything reminds me of herr.lang.StackOverflow

            /*
            for (int i = 1; i <= 100; i++)
            {

                Console.WriteLine($"For number: {i}, result: {GetFizzier(i)}"); // learn.microsoft.NET hah

            }
            */

            int[] numbers = { 23, 8, 15, 42, 4, 16 }; // what do they mean..

            /*

            Console.Write("Numbers: ");
            Sortd.PrintFArray(numbers);

            Sortd.BubbleSort(numbers);

            Console.Write("Bubbled numbers: ");
            Sortd.PrintFArray(numbers);

            */

            /*

            Console.Write("Numbers: ");
            Sortd.PrintFArray(numbers);

            Sortd.QuickSort(numbers, 0, numbers.Length - 1);

            Console.Write("Quickd numbers: ");
            Sortd.PrintFArray(numbers);

            */

            Console.Write("Numbers: ");
            Sortd.PrintFArray(numbers);

            PSortd.Sort(numbers);

            Console.Write("PSortd numbers: ");
            Sortd.PrintFArray(numbers); // i mean.. how different of a jump it is than the non-lsp -> lsp jump
                                        // compared to non-copilot -> copilot jump
                                        // tbh and tbf, lsp is still magik in a way to me lol

            MTStuff mTStuff = new MTStuff();
            await mTStuff.RunSomethingIG();

            // bin and tl;dll
            Binz<int> binz = new Binz<int>();
            binz.Insert(6);
            binz.Insert(9);
            binz.Insert(420);
            binz.Insert(421); // brother COBOLs (jkjkjk cmon...)

           /*
           var funny = binz.InDisOrderTraversal() // ladies and gentlemen, with great pleasure i introduce myself to... drumroll plz..
                .Where(x => x == 6 || x == 9) // LINQ!!!!!! LMAO!!!!
                .ToArray();

            Console.Write("funny: ");
            Sortd.PrintFArray(funny);

            Console.Write("\nnot funny: ");
            Sortd.PrintFArray(binz.PostDisOrderTraversal()
                .Where(x => x != 6 && x != 9)
                .ToArray());

            Console.Write("\navrg: ");
            Console.WriteLine(funny
                .Average());

            Console.Write("\nnot funny avrg: ");
            Console.Write(binz.PostDisOrderTraversal()
                .Where(x => x != 6 && x != 9)
                .Average());

            Console.Write("\npre-ordered: ");
            Sortd.PrintFArray(binz.PreDisOrderTraversal()
                .Where(x => x % 70 == 0)
                .ToArray());


           <STARTEND>
                    i'm tired, boss
                            and honestly, literally done



              laging pagod



            never wanted any of the perks and titles


                            never thought would even deserve them, 
           
                                                                        how pathetic

            with the documentation i write tomorrow in ms word, i can honestly say, i experienced way more i hoped or planned

            and with everything that transpired prior, don't know why i even bothered trying

            fuck E/A

            fuck e/acc

            fuck x and the formerly tpot gang

            have fun my friends

            wish you luck

            should've just left, a long fucking time ago

            sayonara
           </ENDEND>
            */

            Sortd.PrintFArray(binz.PreDisOrderTraversal()
                .ToArray());
            Console.WriteLine();

            Sortd.PrintFArray(binz.InDisOrderTraversal()
                .ToArray());
            Console.WriteLine();

            Sortd.PrintFArray(binz.PostDisOrderTraversal()
                .ToArray());
            Console.WriteLine();

        }

    }

    class Sortd
    {
        public static void PrintFArray(int[] arr)
        {
            Console.Write("{ ");
            foreach (int num in arr)
            {
                Console.Write(num + " "); // and this was mostly tabbed in VS lmao, Rapid Application Development mos def rn
            }
            Console.Write("}\n");
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

    class PSortd
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                if (i % 2 == 0)
                {
                    // what is even
                    Parallel.For(0, n / 2, j =>
                    {
                        if (arr[2 * j] > arr[2 * j + 1])
                        {
                            Swap(arr, 2 * j, 2 * j + 1);
                        }
                    });

                }
                else
                {
                    // what is odd
                    Parallel.For(0, (n - 1) / 2, j =>
                    {
                        if (arr[2 * j + 1] > arr[2 * j + 2])
                        {
                            Swap(arr, 2 * j + 1, 2 * j + 2);

                        }
                    });
                }
            }
        }

        private static void Swap(int[] arr, int i, int j) // man... for such things.. where you already define the implementation above
                                                          //          and just move down to write the definition.. and VS is like - `oh yea, arr, i and j of the Swap function
                                                          //                                                                i know them
                                                          //                                                                                 my best friends`
                                                          //                                                                        lmao
        {
            int temp = arr[i];
            arr[i]= arr[j]; 
            arr[j]= temp; // this too hehe
        }
    
    }

    /*
	 *
	 * written in nvim/windows terminal (used to be PowerShell), compiled with > csc /t:exe /out:FizzualBuzzic.exe FizzualBuzzic.cs
	 * 
	 * re-written in VS (non-code ofc) cuz updating csc was a nightmare
	 *
	 */

}

