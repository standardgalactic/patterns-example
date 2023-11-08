using System.Net;

namespace Patterns.OtherPatterns;

public class WebClientCall{
    static Dictionary<string,Task<string>> _cache = new Dictionary<string,Task<string>>();
    Task<string> GetWebPageAsync (string uri)
    {
        lock(_cache)
            if (_cache.TryGetValue (uri, out var downloadTask)) 
                return downloadTask;
            else
                return _cache [uri] = new WebClient().DownloadStringTaskAsync (uri);
    }
}