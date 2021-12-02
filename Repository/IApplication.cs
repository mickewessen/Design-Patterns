namespace Repository
{
    public interface IApplication
    {
        IDataRepository DataRepository { get; set; }

        void Run();
    }
}