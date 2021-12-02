using Strategy.Message;
using Strategy.Messagehandler;

namespace Strategy
{
    public interface IApplication
    {
        ISendMessage SendMessage { get; set; }
        IEmail Email { get; set; }
        IFacebook Facebook { get; set; }
        ISMS SMS { get; set; }

        void Run();
    }
}