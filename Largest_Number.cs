Using System;
class Largest_Number
{
    public static void LargestNumber()
    {

        Console.WriteLine("Enter three Numbers");

        double num1 =Convert.ToDouble(Console.ReadLine());
        double num2 =Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());

         double result = Math.Max(num1,Math.Max( num2, num3));

        Console.WriteLine("Largest Number is:" + result);

    }
}
