class Program
{
    public static void Main(string[] args)
    {
        int a = 2;
        int b = 3;
        Console.WriteLine(CountSequences(a, b));
    }

    public static int CountSequences(int a, int b)
    {
        if (a == 0 && b == 0)
        {
            return 1;
        }

        if (a < 0 || b < 0)
        {
            return 0;
        }

        if (a == 0)
        {
            return CountSequences(b - 1, 0);
        }

        if (b == 0)
        {
            return CountSequences(a - 1, 0);
        }

        return CountSequences(a - 1, b) + CountSequences(a, b - 1);
    }
}