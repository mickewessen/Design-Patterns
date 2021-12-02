using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Marked : TextInputDecorator, IMarked
    {
        public Marked(ITextInput text): base(text)
        {
            StartTag = "<mark>";
            EndTag = "</mark>";
        }
    }
}
