using Newtonsoft.Json;

namespace FinanceNews.Web.Models;

public class News
{
    [JsonProperty("pagination")]
    public Pagination Pagination { get; set; }

    [JsonProperty("data")]
    public List<NewsArticle> Data { get; set; }
}
