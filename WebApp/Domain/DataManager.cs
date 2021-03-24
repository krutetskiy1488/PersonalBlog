using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain
{
    public class DataManager
    {
        public ITextFieldsRepositories TextFields { get; set; }
        public IArticlesRepositories Articles { get; set; }
        public IDescriptionRepositories Description { get; set; }

        public DataManager(ITextFieldsRepositories textFields, IArticlesRepositories articles, IDescriptionRepositories description)
        {
            TextFields = textFields;
            Articles = articles;
            Description = description;
        }
    }
}
