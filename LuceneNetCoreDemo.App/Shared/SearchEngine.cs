using Lucene.Net.Search;

namespace LuceneNetCoreDemo.App.Shared
{
    /// <summary>
    /// facade around lucene.net's movie index
    /// </summary>
    public class SearchEngine : ISearchEngine
    {
        private readonly MovieIndex index;

        public SearchEngine()
        {
            index = new MovieIndex(Settings.IndexLocation);
        }

        public void BuildIndex() => index.BuildIndex(Repository.GetMoviesFromFile());

        public SearchResults Search(string query)
        {
            var result = index.Search(query);
            return result;
        }

    }
}