using System;

namespace HumanExtension;

public sealed class OrdinaryHuman
{
    private readonly int _age;
    private readonly int _weight;

    public OrdinaryHuman(int weight)
    {
        _weight = weight;
    }

    public void GoToWork()
    {
        Console.WriteLine("Going to work");
    }

    public void PayBills()
    {
        Console.WriteLine("Paying Bills");
    }
}
