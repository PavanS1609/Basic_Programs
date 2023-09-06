using System;

class Powerof2
{
   public static void PowerOf2()
    {
        for (int N = 0; N < 31; N++)
        {
            double power = Math.Pow(2, N);
            Console.WriteLine(power);
        }

    }
        
       
}
