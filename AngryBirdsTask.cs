using Avalonia.Input;
using System;

namespace AngryBirds;

public static class AngryBirdsTask
{
    public static double FindSightAngle(double v, double distance)
    {
        double g = 9.8;
        double sightAngle = 0.5 * Math.Asin(g * distance / Math.Pow(v, 2));
        return sightAngle;
    }
}