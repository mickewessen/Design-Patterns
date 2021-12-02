using Decorator.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Application : IApplication
    {

        public ITextInput TextInput { get; set; }
        public Application(ITextInput textInput)
        {
            TextInput = textInput;
        }

        public void Run()
        {            
            Console.WriteLine("Decorator");
            Console.WriteLine("----------------------");
            Console.WriteLine("Selet an Tag-Style");
            Console.WriteLine("----------------------");
            Console.WriteLine("A: Show finished text");
            Console.WriteLine("B: Add Bold");
            Console.WriteLine("C: Add Deleted");
            Console.WriteLine("D: Add Emphasized");
            Console.WriteLine("E: Add Important");
            Console.WriteLine("F: Add Inserted");
            Console.WriteLine("G: Add Italic");
            Console.WriteLine("H: Add Marked");
            Console.WriteLine("I: Add Smaller");
            Console.WriteLine("J: Add SubScript");
            Console.WriteLine("K: Add SuperScript");
            Console.WriteLine("X: Quit Program");
            Console.WriteLine("Please enter your text");

            var newTextInput = TextInput;
            TextInput.SetUserInput();
            var input = TextInput;

            while (true)
            {

                Console.WriteLine("Add a tag style or press A for finished: ");
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'a' or 'A':
                        Console.WriteLine($"Decorated text: {TextInput.GetTextInput()}");
                        TextInput = newTextInput;
                        break;

                    case 'b' or 'B':
                        Console.WriteLine("Add Bold text");
                        TextInput = new Bold(TextInput);
                        break;

                    case 'c' or 'C':
                        Console.WriteLine("Add Deleted text");
                        TextInput = new Deleted(TextInput);
                        break;

                    case 'd' or 'D':
                        Console.WriteLine("Add Emphasized text");
                        TextInput = new Emphasized(TextInput);
                        break;

                    case 'e' or 'E':
                        Console.WriteLine("Add Important text");
                        TextInput = new Important(TextInput);
                        break;

                    case 'f' or 'F':
                        Console.WriteLine("Add Inserted text");
                        TextInput = new Inserted(TextInput);
                        break;

                    case 'g' or 'G':
                        Console.WriteLine("Add Italic text");
                        TextInput = new Italic(TextInput);
                        break;

                    case 'h' or 'H':
                        Console.WriteLine("Add Marked text");
                        TextInput = new Marked(TextInput);
                        break;
                    case 'i' or 'I':
                        Console.WriteLine("Add Smaller text");
                        TextInput = new Smaller(TextInput);
                        break;
                    case 'j' or 'J':
                        Console.WriteLine("Add SubScript text");
                        TextInput = new SubScript(TextInput);
                        break;

                    case 'k' or 'K':
                        Console.WriteLine("Add SuperScript text");
                        TextInput = new SuperScript(TextInput);
                        break;

                    case 'x' or 'X':
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }
    }
}
