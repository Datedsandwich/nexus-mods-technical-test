using System;
using System.Linq;
using System.Text;
class StarPrinter
{
    public void PrintStarsLoop(int number)
    {
        string output = string.Empty;

        for (int i = 0; i < number; i++)
        {
            output += "*";
        }

        Console.Write(output);
    }

    public void PrintStarsRecursive(int number)
    {
        if (number <= 0)
        {
            return;
        }

        Console.Write("*");
        PrintStarsRecursive(--number);
    }

    public void PrintStarsLinq(int number)
    {
        string output = Enumerable.Repeat("*", number)
                     .Aggregate(new StringBuilder(), (sb, s) => sb.Append(s))
                     .ToString();

        Console.Write(output);
    }

    public void PrintStarsOnlyString(int number)
    {
        string output = new string('*', number);

        Console.Write(output);
    }
}