namespace Decorator
{
    public interface IApplication
    {
        ITextInput TextInput { get; set; }

        void Run();
    }
}