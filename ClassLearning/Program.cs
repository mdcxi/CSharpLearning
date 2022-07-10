using System;

class @class
{
    public string myVariable = string.Empty;

    public @class () {}

    public void PrintSomething(int value1, int value2)
    {
        Console.WriteLine("Hello {0} , How are you? {1}", value1, value2);
    }

    public int AutoImplementedProperty { get; set; }

    private int myValue;
    public int GetInstance
    {
        get { return myValue; }
        set { myValue = value;  }
    }
}