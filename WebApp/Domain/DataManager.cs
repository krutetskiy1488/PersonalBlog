using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain
{
    public class DataManager
    {
        public ITextFieldsRepositories TextFields { get; set; }
        public IArticlesRepositories Articles { get; set; }

        public DataManager(ITextFieldsRepositories textFields, IArticlesRepositories articles)
        {
            TextFields = textFields;
            Articles = articles;
        }
    }
}
