using AboutMeClass;


namespace Homework;

class Program
{
    public static void Main()
    {
        Nail nail = new(new Student(1, "ИТИС", 409, true));
        Console.WriteLine(nail.Age);
        Console.WriteLine(nail.FirstName);
        Console.WriteLine(nail.LastName);
        Console.WriteLine(nail.GetFullName);
        Console.WriteLine(nail.CurrentLanguageProgramm);
        Console.WriteLine(nail.IsAdult);
        Array.ForEach(nail.StackTechno.ToArray(), Console.Write);
        Console.WriteLine(nail.GymYearExperience);
        
    }

    public static void PrintArray(string[] array)
    {
        foreach (string word in array)
            Console.WriteLine(word);
    }
}
