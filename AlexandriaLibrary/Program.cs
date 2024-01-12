using Alexandria;
using Alexandria.Deserializer;
using Alexandria.Repository;

public class Program
{
    public static void Main(string[] args)
    {
        IDeserializer deserializer = new Deserializer();
        IFinder finder = new FinderByFile(deserializer);
        var searchEngine = new SearchEngine(finder);

        Console.WriteLine("Enter the document number to search:");
        var documentNumber = Console.ReadLine();
        var result = searchEngine.SearchDocument(documentNumber);

        Console.WriteLine("Search Result:");
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

    }
}
