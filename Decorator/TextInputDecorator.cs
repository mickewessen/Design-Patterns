using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class TextInputDecorator : ITextInput
    {
        public ITextInput TextInput { get; set; }
        public string StartTag;
        public string EndTag;

        protected TextInputDecorator(ITextInput textInput)
        {
            TextInput = textInput;
        }

        public string GetTextInput()
        {
            return StartTag + TextInput.GetTextInput() + EndTag;
        }

        public void SetUserInput()
        {
            throw new NotImplementedException();
        }
    }
}
