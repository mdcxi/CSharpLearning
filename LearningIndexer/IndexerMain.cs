namespace Indexer;

public class IndexerMain
{
    static void Main()
    {
        var collection = new Indexer<string>();
        collection[0] = "Huong Chu =)))";
        Console.WriteLine(collection[0]);
    }
}