using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejlhåndtering2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string filePath = @"c:\temp\tal.txt";
            bool fileExists = System.IO.File.Exists(filePath);
            if (fileExists == false)
                throw new System.ApplicationException($"Filen {filePath} eksister");

            string textInFile = "";
            try
            {
                textInFile = System.IO.File.ReadAllText(filePath);
            }
            catch (Exception)
            {
                throw;
            }

            try
            {
                int intInFile = System.Convert.ToInt32(textInFile);
                intInFile++;
                System.IO.File.WriteAllText(filePath, System.Convert.ToString(intInFile));
            }
            catch (Exception)
            {
                throw new ApplicationException("Indhold kan ikke konverteres til et heltal");
            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
