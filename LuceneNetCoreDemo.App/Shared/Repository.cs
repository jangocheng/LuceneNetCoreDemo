using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace LuceneNetCoreDemo.App.Shared
{
    public class Repository
    {
        public static IEnumerable<Movie> GetMoviesFromFile() => JsonConvert.DeserializeObject<List<Movie>>(File.ReadAllText(Settings.MovieJsonFile));
    }
}