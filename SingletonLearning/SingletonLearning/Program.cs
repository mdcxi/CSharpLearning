using System;
using System.Reflection;

sealed class Singleton
{
    private Singleton () {} //client code khong the khoi tao object cua class 
    
    //khoi tao thanh vien static cua class Singleton
    private static readonly Singleton _instance = new Singleton();
    
    //truy xuat tu client code de lay object cua class Singleton
    public static Singleton Instance => _instance;
    
    private int _count = 0;
    public void Increase() => _count++;
    public int Count => _count;
}

class Program
{
    static void Main()
    {
        Console.Title = "Singleton Design Pattern";
        Console.WriteLine($"Start: {Singleton.Instance.Count}");
        Singleton.Instance.Increase();
        Console.WriteLine($"First increment: {Singleton.Instance.Count}");
        Singleton.Instance.Increase();
        Console.WriteLine($"Second increment: {Singleton.Instance.Count}");
        Singleton.Instance.Increase();
        Console.WriteLine($"Third increment : {Singleton.Instance.Count}");
        Console.ReadKey();
    }
}
