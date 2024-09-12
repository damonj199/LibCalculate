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
}
