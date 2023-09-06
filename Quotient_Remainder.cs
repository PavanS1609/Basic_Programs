using System;

class QuoAndRem
{
    public static void Quo_Rem()
    {
        int num1=Convert.ToInt32(Console.ReadLine());   
        int num2=Convert.ToInt32(Console.ReadLine());
         
        int result =num1 % num2;
        Console.WriteLine(result);
    }
}