using System;
using System.Linq;
using WebApp.Domain.Entities;

namespace WebApp.Domain.Repositories.Abstract
{
    public interface IArticlesRepositories
    {
        IQueryable<Article> GetArticles();
        Article GetArticlesById(Guid id);
        void SaveArticles(Article entity);
        void DeleteArticles(Guid id);
    }
}
