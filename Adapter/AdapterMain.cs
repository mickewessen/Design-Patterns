using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AdapterMain
    {
        public void Run()
        {
            //// Skriv en adapter för ReturningStrings som kan konsumeras av PrintingInts           

            //// ReturningStrings
            //// PrintingInts


            //// OBS TRASIG KOD - TA BORT NÄR DU BÖRJAR KODA
            //// Det jag vill göra men inte kan är
            //ReturningStrings returningStrings = new();
            //PrintingInts printingInts = new();
            ////printingInts.Print(returningStrings.ReturnString());
            ///
            ReturningStrings returningStrings = new();
            PrintingInts printingInts = new();
            AdapterService service = new();
            printingInts.Print(service.ConvertToInt());
        }
    }
}
