using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain
{
    public class DataManager
    {
        public ITextFieldsRepositories TextFields { get; set; }
        public IServiceItemsRepositories ServiceItems { get; set; }

        public DataManager(ITextFieldsRepositories textFields, IServiceItemsRepositories serviceItems)
        {
            TextFields = textFields;
            ServiceItems = serviceItems;
        }
    }
}
