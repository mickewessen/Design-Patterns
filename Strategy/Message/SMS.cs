using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Message
{
    public class SMS : ISMS
    {
        public void Send(string message)
        {
            Console.WriteLine($"sending \"{message}\" as a sms");
        }
    }
}
