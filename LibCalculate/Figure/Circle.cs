﻿using LibCalculate.Interfaces;

namespace LibCalculate.Figure;

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Area()
    {
        return Math.PI * Math.Pow(Radius, 2d);
    }
}
