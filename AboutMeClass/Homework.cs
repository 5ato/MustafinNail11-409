using System.Diagnostics;

namespace AboutMeClass;

public record Person(int BirthYear, string FirstName, string LastName)
{
    public int Age
    {
        get
        {
            return DateTime.Today.Year - BirthYear;
        }
    }

    public bool IsAdult
    {
        get
        {
            return Age >= 18;
        }
    }

    public string GetFullName
    {
        get
        {
            return $"{LastName} {FirstName}";
        }
    }

    private readonly int _health = 100;
}


public class StatusPosition;

public class Student(int course, string faculty, int group, bool isForeigner) 
    : StatusPosition
{
    public int Course = course;
    public string Faculty = faculty;
    public int Group = group;
    public bool IsForeigner = isForeigner;
}

public record Nail(StatusPosition StatusPosition, int BirthYear = 2006, string FirstName = "Наиль", string LastName = "Мустафин") 
    : Person(BirthYear, FirstName, LastName)
{
    public List<string> StackTechno = ["Python", "JavaScript", "HTML", "CSS"];
    public int GymYearExperience => DateTime.Today.Year - 2022;
    public string CurrentLanguageProgramm = "C#";
    public string NotLikedLectionPara = "Матанал";
}
