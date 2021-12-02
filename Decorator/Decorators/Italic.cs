using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Italic : TextInputDecorator, IItalic
    {
        public Italic(ITextInput text) : base(text)
        {
            StartTag = "<i>";
            EndTag = "</i>";
        }
    }
}
