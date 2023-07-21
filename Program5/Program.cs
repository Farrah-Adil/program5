using System;

class Exponent
{
    static void Main()
    {
        int b, e;
        Console.Write("Enter base:");
        int.TryParse(Console.ReadLine(),out b);
        Console.Write("Enter exponent:");
        int.TryParse(Console.ReadLine(), out e);
        Console.WriteLine("{0} to the power {1} = {2}", b, e, IntegerPower(b, e));
       
    }

    static int IntegerPower(int b, int e)
    {
        if (e < 1) throw new ArgumentException("Exponent must be positive");
        int power = 1;
        int num = 1;

        while (num <= e)
        {
            power *= b;
            num++;
        }

        return power;
    }
}