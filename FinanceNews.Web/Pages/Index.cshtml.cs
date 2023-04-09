using FinanceNews.Web.Models;
using FinanceNews.Web.Services.Abstract;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinanceNews.Web.Pages;

public class IndexModel : PageModel
{
    public News news;
    private readonly ILogger<IndexModel> _logger;
    private readonly INewsService _newsService;

    public IndexModel(ILogger<IndexModel> logger, INewsService newsService)
    {
        _logger = logger;
        _newsService = newsService;
    }

    public void OnGet()
    {
        news = _newsService.GetFinanceNews(0);
    }

    public void OnGetLoadMoreNews(int offset)
    {
        news = _newsService.GetFinanceNews(offset);
    }
}