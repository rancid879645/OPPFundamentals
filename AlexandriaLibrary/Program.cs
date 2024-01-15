using Alexandria;
using Alexandria.Deserializer;
using Alexandria.Repository;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
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

            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Q)
                    break;
            }

            Thread.Sleep(100);
        }

        

    }
}
