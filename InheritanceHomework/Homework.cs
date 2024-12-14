namespace InheritanceHomework;

// ----------------------------------------Задача 1------------------------------------------------
public class Shape
{
    public virtual double CalculateArea() { return 0; }

    public virtual double CalculatePerimeter() { return 0; }
}

public class Rectangle(double sideA, int sideB) : Shape
{
    public double SideA = sideA;
    public double SideB = sideB;

    public override double CalculateArea()
    {
        return SideA * SideB;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (SideA + SideB);
    }
}

public class Circle(double radius) : Shape
{
    public double Radius = radius;

    public override double CalculateArea()
    {
        return Math.PI * (Radius * Radius);
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Triangle(double sideA, double sideB, double sideC) : Shape
{
    public double SideA = sideA;
    public double SideB = sideB;
    public double SideC = sideC;

    public override double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }

    public override double CalculateArea()
    {
        double p = CalculatePerimeter() / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }
}

// -----------------------------Задача 2--------------------------------------------

public class A
{
    public virtual void PrintMessage() => Console.Write('A');
}

public class B : A
{
    public override void PrintMessage() => Console.Write('B');
}
public class C : A
{
    public void PrintMessage() => Console.Write('C');
}