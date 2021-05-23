using Data;
namespace Infrastructure
{
    public class BaseControllerWithDatabase : BaseController
    {
        public BaseControllerWithDatabase(Data.DatabaseContext databaseContext) : base()
        {
            MyDatabaseContext = databaseContext;
        }

        protected Data.DatabaseContext MyDatabaseContext { get; }
    }
}