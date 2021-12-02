using Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Emphasized : TextInputDecorator, IEmphasized
    {
        public Emphasized(ITextInput text) : base(text)
        {
            StartTag = "<em>";
            EndTag = "</em>";
        }
    }
}
