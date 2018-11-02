namespace LuceneNetCoreDemo.App.Shared
{
    public interface ISearchEngine
    {
        void BuildIndex();
        SearchResults Search(string query);
    }
}