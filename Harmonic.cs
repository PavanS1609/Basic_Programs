using System;
class Harmonic
{
   public static void harmonic()
    {
        Console.WriteLine("enter the value of N");
        int N = Convert.ToInt32(Console.ReadLine());
        if (N != 0)
        {
            float harmonic_value = 0.0f;
            for (float i = 1; i <= N; i++)
            {
                harmonic_value += 1 / i;

            }
            Console.WriteLine(harmonic_value);
        }
        else
        {
            Console.WriteLine("number must be greatet then zero");
        }
    }
}
