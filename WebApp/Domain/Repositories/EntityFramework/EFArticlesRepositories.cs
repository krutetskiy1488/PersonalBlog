using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApp.Domain.Entities;
using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain.Repositories.EntityFramework
{
    public class EFArticlesRepositories : IArticlesRepositories
    {
        private readonly AppDbContext context;

        public EFArticlesRepositories(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Article> GetArticles()
        {
            return context.Articles;
        }

        public Article GetArticlesById(Guid id)
        {
            return context.Articles.FirstOrDefault(c => c.Id == id);
        }

        public void SaveArticles(Article entity)
        {
            context.Entry(entity).State = entity.Id == default ? EntityState.Added : EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteArticles(Guid id)
        {
            context.Articles.Remove(new Article() { Id = id });
            context.SaveChanges();
        }
    }
}
