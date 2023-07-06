using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public bool HasSideCar { get; set; } = false;
    public override void DriveAbstract()
    {
        Console.WriteLine("The motorcycle is driving.");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("This is a motorcycle.");
    }
}