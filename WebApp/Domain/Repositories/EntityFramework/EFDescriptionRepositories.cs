using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Domain.Entities;
using WebApp.Domain.Repositories.Abstract;


namespace WebApp.Domain.Repositories.EntityFramework
{
    public class EFDescriptionRepositories : IDescriptionRepositories
    {
        private readonly AppDbContext context;

        public EFDescriptionRepositories(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Description> GetDescription()
        {
            return context.Description;
        }

        public Description GetDescriptionById(Guid id)
        {
            return context.Description.FirstOrDefault(c => c.Id == id);
        }

        public void SaveDescription(Description entity)
        {
            context.Entry(entity).State = entity.Id == default ? EntityState.Added : EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteDescription(Guid id)
        {
            context.Description.Remove(new Description() { Id = id });
            context.SaveChanges();
        }
    }
}
