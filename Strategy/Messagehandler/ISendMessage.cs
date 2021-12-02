using Strategy.Message;

namespace Strategy.Messagehandler
{
    public interface ISendMessage
    {
        IMessage Message { get; set; }

        void Send(string message);
    }
}