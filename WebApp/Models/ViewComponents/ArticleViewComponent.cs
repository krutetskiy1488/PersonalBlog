using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;

namespace WebApp.Models.ViewComponents
{
    public class ArticleViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;

        public ArticleViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult) View("Default", dataManager.Articles.GetArticles()));
        }
    }
}
