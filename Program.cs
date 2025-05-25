class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        if (!Int32.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Error: Not a valid number");
            return;
        }

        Console.WriteLine("Enter second number:");
        if (!Int32.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Error: Not a valid number");
            return;
        }

        Console.WriteLine("Enter operator (&, | or ^):");
        string op = Console.ReadLine();

        if (op.Length != 1 || (op[0] != '&' && op[0] != '|' && op[0] != '^'))
        {
            Console.WriteLine("Error: Wrong operator");
            return;
        }

        int result = 0;
        switch (op[0])
        {
            case '&':
                result = a & b;
                break;
            case '|':
                result = a | b;
                break;
            case '^':
                result = a ^ b;
                break;
        }

        Console.WriteLine($"Decimal: {result}");
        Console.WriteLine($"Binary: {Convert.ToString(result, 2)}");
        Console.WriteLine($"Hexadecimal: {Convert.ToString(result, 16)}");
    }
}