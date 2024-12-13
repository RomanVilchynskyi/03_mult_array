using System.Text;

internal class Program
{
    static int sum(params int[] arr)
    {
        return arr.Sum();
    }
    private static void Main(string[] args)
    {
        string text = "hello world C# !!! ";
        //char.ToUpper(text[0]);
        char[] chars = text.ToCharArray();
        chars[0] = char.ToUpper(chars[0]);
        Console.WriteLine(text);

        text = new string(chars);
        Console.WriteLine(text);

        Console.WriteLine("Contains :: " + text.Contains("C#"));
        Console.WriteLine("Starts with  :: " + text.StartsWith("C#"));
        Console.WriteLine("Ends with  :: " + text.EndsWith("C#"));

        var index = text.IndexOf("C#");// -1 not found
        Console.WriteLine($"Index of :: {index}");
        index = text.IndexOfAny("abcd".ToCharArray());
        Console.WriteLine($"Index of any:: {index}");

        string one = "Apple", two = "Apricot";
        Console.WriteLine($"CompareTo :: {one.CompareTo(two)}");
        two = "apple";
        Console.WriteLine($"CompareTo :: {one.CompareTo(two)}");
        Console.WriteLine($"CompareTo :: {String.CompareOrdinal(one, two)}");
        Console.WriteLine($"CompareTo :: {String.Compare(one, two, true)}");

        string num = "1,2,3,4,5,6,7,8,9,10";
        string[] numbers = num.Split(',');

        string[] colors = { "red", "blue", "yellow" };
        Console.WriteLine(String.Join("---", colors));

        Console.WriteLine($"Sum :: {sum(1, 2, 3, 4, 5, 6, 7)}");
        /*StringBuilder text = new StringBuilder("hello world");
        Console.WriteLine(text);
        text[0] = char.ToUpper(text[0]);
        Console.WriteLine(text.Capacity);
        Console.WriteLine(text);
        text.AppendLine("Test Append line");
        text.Append("!!! c#");
        Console.WriteLine(text);
        text.Insert(0, " C# ");
        Console.WriteLine(text);
        text.Remove(5, 10);
        Console.WriteLine(text);
        text.Replace("C#", "JS");
        Console.WriteLine(text);
        Console.WriteLine(text.Capacity);*/
    }
}