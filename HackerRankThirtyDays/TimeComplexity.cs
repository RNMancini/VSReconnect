using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            isPrime(x);
        }
    }
    public static void isPrime(int n) 
    {
        bool isPrime = n > 1;
        for(int i = 2; i <= Math.Sqrt(n); i++) 
        {
            if(n % i == 0) {
                isPrime = false;
                break;
            }
        }
    Console.WriteLine(isPrime ? "Prime": "Not prime");
    }
}