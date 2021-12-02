using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class TextInput : ITextInput
    {
        public string TextInputAsString { get; set; }

        public TextInput()
        {
            TextInputAsString = "";
        }

        public string GetTextInput()
        {
            return TextInputAsString;
        }

        public void SetUserInput()
        {
            bool validInput = false;
            while(!validInput)
            {
                string userInput = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(userInput))
                {
                    validInput = true;
                    TextInputAsString = userInput;
                }
            }
        }
    }
}
