namespace Homework;

class Program
{
    public static void Main()
    {
        Console.WriteLine(StringHomework.LongestUniqueSubstring.Solution("abbdefg"));
    }

    public static void PrintArray(string[] array)
    {
        foreach (string word in array)
            Console.WriteLine(word);
    }
}
