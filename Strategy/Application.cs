using Strategy.Message;
using Strategy.Messagehandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Application:IApplication
    {

        public ISendMessage SendMessage { get; set; }
        public ISMS SMS { get; set; }
        public IEmail Email { get; set; }
        public IFacebook Facebook { get; set; }

        public Application(ISendMessage sendMessage, ISMS sms, IEmail email, IFacebook facebook)
        {
            SendMessage = sendMessage;
            SMS = sms;
            Email = email;
            Facebook = facebook;
            sendMessage.Message = sms;
        }

        public void Run()
        {
            Console.WriteLine("Strategy");
            var message = "This is the message";
            SendMessage.Send(message);
        }

    }
}
