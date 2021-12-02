using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class SuperScript : TextInputDecorator, ISuperScript
    {
        public SuperScript(ITextInput text): base(text)
        {
            StartTag = "<sup>";
            EndTag = "</sup>";
        }
    }
}
