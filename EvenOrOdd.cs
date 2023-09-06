using System;

class EvenOrOdd
{
    public static void Even_Odd()
    {
        Console.WriteLine("Enter the Number");
        int Number = Convert.ToInt32(Console.ReadLine());
        if (Number % 2 == 0)
        {
            Console.WriteLine("EvenNumber");
        }
        else
        {
            Console.WriteLine("OddNumber");
        }


    }
}
