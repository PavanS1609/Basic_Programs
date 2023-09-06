using System;

// See https://aka.ms/new-console-template for more information
class SwapNumbers
{ 
    public static void Swapnumbers()
    {
        int a = 10;
        int b = 20;
        a = a + b;
        b = b - a;
        a = a - b;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

