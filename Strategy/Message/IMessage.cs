using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Message
{
    public interface IMessage
    {
        public void Send(string message);
    }
}
