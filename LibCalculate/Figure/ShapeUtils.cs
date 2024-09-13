using LibCalculate.Interfaces;

namespace LibCalculate.Figure;

public class ShapeUtils
{
    public static double GetArea(IShape shape)
    {
        return shape.Area();
    }
}
