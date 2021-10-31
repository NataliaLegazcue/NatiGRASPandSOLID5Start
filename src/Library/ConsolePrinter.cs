using System;
using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintTicket(IRecipeContent RecipeContent)
        {
            Console.WriteLine(RecipeContent.GetTextToPrint());
        }
    }
}