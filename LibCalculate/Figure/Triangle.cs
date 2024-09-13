using LibCalculate.Interfaces;

namespace LibCalculate.Figure;

public class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if(sideA < 0 || sideB < 0 || sideC < 0)
            throw new ArgumentException("Проверьте правильность введенных данных");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double Area()
    {
        double poluPerimeter = (SideA + SideB + SideC) / 2;
        var square = Math.Sqrt(
            poluPerimeter
            * (poluPerimeter - SideA)
            * (poluPerimeter - SideB)
            * (poluPerimeter - SideC)
        );

        return square;
    }

    public bool IsRightTriangle()
    {
        return (SideA == Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2))
               || SideB == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
               || SideC == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)));
    }
}
