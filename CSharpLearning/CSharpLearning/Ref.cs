using System;

class Ref
{
    static void IncreaseValue(ref int value)
    {
        value++;
    }

    static void MainRef (string[] args)
    {
        int value = 5;
        Console.WriteLine("Value before increasing: {0}", value);
        
        IncreaseValue(ref value);
        Console.WriteLine("Value after increasing: {0}", value);
        Console.ReadKey();

    }
}