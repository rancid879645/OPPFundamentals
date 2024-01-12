using Alexandria.Deserializer;

namespace Alexandria.Repository
{
    public class FinderByFile:IFinder
    {
        private const string _folderPath = "C:/Users/Jonathan_Velosa/Documents/AlexandriaRepo";
        private readonly IDeserializer _deserializer;

        public FinderByFile(IDeserializer deserializer)
        {
            _deserializer = deserializer;
        }

        public List<object> FindFileById(string documentId)
        {
            var resultList = new List<object?>();
            try
            {
                if (!Directory.Exists(_folderPath)) return resultList;
                var folderFiles = Directory.GetFiles(_folderPath);

                var filteredFiles = folderFiles
                    .Where(file => FileContainsDocumentId(file, documentId))
                    .ToList();

                resultList = filteredFiles.Select(file => _deserializer.DeserializeJson(file)).ToList();

            }
            catch (Exception e)
            {
                Console.WriteLine($"An error has occurred: {e}");
            }
            return resultList;
        }

        private static bool FileContainsDocumentId(string path, string documentId)
        {
            var result = false;

            try
            {
                result = Path.GetFileName(path).Contains(documentId);
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error has occurred in FileContainsDocumentId: {e}");
            }
            return result;
        }
    }
}
