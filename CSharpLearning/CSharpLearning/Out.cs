namespace CSharpLearning;

public class Out
{ 
    static void IncreaseValue(out int value)
    {
        value = 0;
        value++;
    }

    static void Main (string[] args)
    {
        int value = 5;
        Console.WriteLine("Value before increasing: {0}", value);
        
        IncreaseValue(out value);
        Console.WriteLine("Value after increasing: " + value);
        Console.ReadKey();
        
        IncreaseValue(out value);
        Console.WriteLine(value);
    }
}