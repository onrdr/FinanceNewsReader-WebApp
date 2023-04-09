using FinanceNews.Web.Models;
using FinanceNews.Web.Services.Abstract;
using Newtonsoft.Json;

namespace FinanceNews.Web.Services.Concrete;

public class NewsService : INewsService
{
    private readonly IConfiguration _configuration;

    public NewsService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public News GetFinanceNews(int offset)
    {
        string apiKey = _configuration.GetValue<string>("API_KEY");
        string baseUrl = _configuration.GetValue<string>("API_URL");

        using var client = new HttpClient();
        client.BaseAddress = new Uri(baseUrl);        
        var parameters = $"?apikey={apiKey}&offset={offset}&date=today&sort=desc";
        HttpResponseMessage response = client.GetAsync(parameters).Result;

        if (response.IsSuccessStatusCode)
        {
            var result = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<News>(result);
        }

        return new News()
        {
            Data = new List<NewsArticle>(),
            Pagination = new Pagination()
        };
    }
}
