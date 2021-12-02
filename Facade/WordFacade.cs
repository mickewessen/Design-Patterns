using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class WordFacade
    {
        List<char> one = new();
        List<char> two = new();
        List<char> three = new();
        List<char> four = new();
        List<char> five = new();

        public void SaveWord()
        {
            Console.WriteLine("Please enter a word");
            string input = Console.ReadLine();
            if (input.Length != 5)
            {
                Console.WriteLine("Enter a word with 5 letters");
                Console.ReadKey(true);
            }
            else
            {
                one.Add(input[0]);
                two.Add(input[1]);
                three.Add(input[2]);
                four.Add(input[3]);
                five.Add(input[4]);
            }
        }

        public void LoadWord()
        {
            char[] word = { one.Last(), two.Last(), three.Last(), four.Last(), five.Last() };
            Console.WriteLine(word);
        }
    }
}
