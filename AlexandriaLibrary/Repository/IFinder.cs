namespace Alexandria.Repository
{
    public interface IFinder
    {
        public List<object> FindFileById(string documentId);
    }
}
