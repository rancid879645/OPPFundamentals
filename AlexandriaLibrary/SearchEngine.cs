using Alexandria.Repository;

namespace Alexandria
{
    public class SearchEngine:ISearchEngine
    {
        private readonly IFinder _finder;
        public SearchEngine(IFinder finder)
        {
            _finder = finder;
        }

        public List<object> SearchDocument(string documentNumber)
        {
            return _finder.FindFileById(documentNumber);
        }
    }
}
