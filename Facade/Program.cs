using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            WordFacade wordFacade = new();
            wordFacade.SaveWord();
            wordFacade.LoadWord();
        }
    }
}
