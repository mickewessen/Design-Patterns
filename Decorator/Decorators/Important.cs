using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Important : TextInputDecorator, IImportant
    {
        public Important(ITextInput text) : base(text)
        {
            StartTag = "<strong>";
            EndTag = "</strong>";
        }
    }
}
