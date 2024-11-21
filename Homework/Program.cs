namespace Homework;

class Program
{
    public static void Main()
    {
        Console.WriteLine(BinarySearch.BinarySearch.Solution([1, 5, 4, 1 ,7, 6, 1, 5, 3], 3));
        Console.WriteLine(123);
    }

    public static void PrintArray(string[] array)
    {
        foreach (string word in array)
            Console.WriteLine(word);
    }
}
