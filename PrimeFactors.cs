using System;

class PrimeFactors
{
    public static void Factors()
    {
        int num =Convert.ToInt32(Console.ReadLine());
        //int N=Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < num; i++)
        {
            if(num % i == 0)
            {
                Console.WriteLine(i);
            }
        }
        

    }
    public static void prime_factors()
    {
        int num1 ;
    }

}
