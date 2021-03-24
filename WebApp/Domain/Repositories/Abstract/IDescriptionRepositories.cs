using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain.Entities;

namespace WebApp.Domain.Repositories.Abstract
{
    public interface IDescriptionRepositories
    {
        IQueryable<Description> GetDescription();
        Description GetDescriptionById(Guid id);
        void SaveDescription(Description entity);
        void DeleteDescription(Guid id);
    }
}
