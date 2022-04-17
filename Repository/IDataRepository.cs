namespace Repository
{
    public interface IDataRepository
    {
        public string GetData();
        public string GetCustomer();
        public string GetAnimal();

        public void Save(string data);
        public string Load(string v);
    }
}