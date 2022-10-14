// Task # 1
// You have to write a function which takes an array of integers "seq" and an integer "target". There exist two elements of the array whose sum is equal to the target. You can assume that there exists only one solution. You have to return the indices of those elements
// Example 1: [1,9,2,19]  Target = 3, Answer = 0,2

// Example 2: [2,4]  Target = 6, Answer =0,1

using System;

class Program
{
    public static void Main(string[] args)
    {

        int[] seq = { 1, 9, 2, 19 };
        int target = 11;
        var sol = FindSolution(seq, target);

        Console.WriteLine($"{sol.a}, {sol.b}");
    }

    public static (int a, int b) FindSolution(int[] seq, int target)
    {
        (bool exists, int index)[] array = new (bool, int)[1000];
        for (int i = 0; i < seq.Length - 1; i++)
        {
            array[seq[i]] = (true, i);
        }

        for (int i = 0; i < seq.Length; i++)
        {
            int a = seq[i];
            int b = target - a;
            if (array[b].exists) return (i, array[b].index);
        }

        return (-1, -1);
    }
}

//////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////

// Task#2
// Given an integer x, return true if x is palindrome integer.

// An integer is a palindrome when it reads the same backward as forward.

// For example, 121 is a palindrome while 123 is not.


// Example 1:
// Input: x = 121
// Output: true
// Explanation: 121 reads as 121 from left to right and from right to left.
// Example 2:


// Example 2:
// Input: x = 14
// Output: false
// Explanation: Reads 41 from right to left. Therefore it is not a palindrome.

// using System;
// using System.Collections.Generic;

// class Program
// {

//     public static void Main(string[] args)
//     {
//         Console.WriteLine(IsPalindrome(12121));
//     }

//     public static bool IsPalindrome(int value)
//     {
//         List<int> integers = new List<int>();

//         while (true)
//         {
//             var remainder = value % 10;
//             integers.Add(remainder);
//             value /= 10;

//             if (value == 0) break;
//         }

//         var count = integers.Count;
//         for (int i = 0; i < count / 2; i++)
//         {
//             var lastIndex = (count - 1) - i;
//             if (integers[i] != integers[lastIndex]) return false;
//         }
//         return true;
//     }
// }
