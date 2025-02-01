using System;

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

        static void Main(string[] args)
        { // everything reminds me of herr.lang.StackOverflow

            for (int i = 1; i <= 100; i++)
            {

                Console.WriteLine($"For number: {i}, result: {GetFizzier(i)}"); // learn.microsoft.NET hah

            }

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

