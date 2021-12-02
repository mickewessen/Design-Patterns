using Strategy.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Messagehandler
{
    public class SendMessage : ISendMessage
    {
        public IMessage Message { get; set; }

        public void Send(string message)
        {
            Message.Send(message);
        }
    }
}
