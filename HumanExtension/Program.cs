using System;

namespace HumanExtension;

class Program
{
    public static void Main(string[] args)
    {
        OrdinaryHuman steve = new(185);
        Console.WriteLine(steve.BreakWalls(89.2));
        Console.ReadLine();
    }
}
