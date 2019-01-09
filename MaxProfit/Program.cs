using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if(A.Length == 0)
        {
            return 0;
        }
        int minPrice = A[0];
        int maxProfit = 0;
        int maxProfitHere = 0;
        for(int i = 0; i < A.Length; i++)
        {
            maxProfitHere = Math.Max(0, A[i] - minPrice);
            minPrice = Math.Min(minPrice, A[i]);
            maxProfit = Math.Max(maxProfit, maxProfitHere);
        }
        return maxProfit;
    }
}