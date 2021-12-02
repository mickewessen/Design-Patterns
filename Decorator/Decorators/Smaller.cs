using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Smaller : TextInputDecorator, ISmaller
    {
        public Smaller(ITextInput text): base(text)
        {
            StartTag = "<small>";
            EndTag = "</small>";
        }
    }
}
