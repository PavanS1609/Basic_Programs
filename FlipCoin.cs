using System;

class FlipCoin
{
    public static void Toss()
    {
        int heads = 1;
        int tails = 0;
        Random r = new Random();
        int result = r.Next(0, 2);
        System.Console.WriteLine(result);
    }

}
