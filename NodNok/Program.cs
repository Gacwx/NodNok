using System;

class Program
{
    public static void Main()
    {
        GetNodNok();
    }


    public static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static int LCM(int a, int b)
    {
        return Math.Abs(a * b) / GCD(a, b);
    }

    public static bool TryParseNumber(string input, out int number)
    {
        return int.TryParse(input, out number) && number > 0;
    }

    public static void GetNodNok()
    {
        int num1, num2;

        Console.Write("Enter the first number: ");
        while (!TryParseNumber(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Error! Enter positive whole number.");
            Console.Write("Enter the first number: ");
        }

        Console.Write("Enter the second number: ");
        while (!TryParseNumber(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Error! Enter positive whole number.");
            Console.Write("Enter the second number: ");
        }

        int gcd = GCD(num1, num2);
        int lcm = LCM(num1, num2);

        Console.WriteLine($"GCD of number {num1} amd {num2}: {gcd}");
        Console.WriteLine($"LCM of number {num1} and {num2}: {lcm}");
    }


}
