using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Inserted : TextInputDecorator, IInserted
    {
        public Inserted(ITextInput text) : base(text)
        {
            StartTag = "<ins>";
            EndTag = "</ins>";
        }
    }
}
