namespace CsharpierConsoleExample;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class ClassName
{
    public string ShortPropertyName { get; set; }

    public void LongUglyMethod(string longParameter1, string longParameter2, string longParameter3)
    {
        this.LongUglyMethod(
            "1234567890",
            "abcdefghijklmnopqrstuvwxyz",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        );
    }
}
