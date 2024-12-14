using InheritanceHomework;


namespace Homework;

class Program
{
    public static void Main()
    {
        var b = new B();
        var c = new C();
        ((A)c).PrintMessage();
        ((A)b).PrintMessage();
        c.PrintMessage();     
    }

    public static void PrintArray(string[] array)
    {
        foreach (string word in array)
            Console.WriteLine(word);
    }
}
