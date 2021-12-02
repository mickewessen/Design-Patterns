namespace Repository
{
    public interface IDataRepository
    {
        string DatabaseType();
        string GetAnimal();
        string GetCustomer();
    }
}