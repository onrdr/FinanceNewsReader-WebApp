using FinanceNews.Web.Models;

namespace FinanceNews.Web.Services.Abstract;

public interface INewsService
{
    News GetFinanceNews(int offset);
}