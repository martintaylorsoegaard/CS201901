using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVariableOpgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = $"{fornavn} {efternavn}";
            Console.WriteLine(samletNavn);
            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);
            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);
            string subNavn = navnLille.Substring(7, 4);
            Console.WriteLine(subNavn);


            string test = "Dette\ter\nen\n\rtest\rTE";
            Console.WriteLine(test);
            string tempPath = @"C:\temp\";
            string newFolder = "TestFolder";
            string newFolderPath = System.IO.Path.Combine(tempPath, newFolder);
            System.IO.Directory.CreateDirectory(newFolderPath);
            string totalPath = $"{newFolderPath}\\TestDoc.txt";
            System.IO.File.WriteAllText(totalPath,test);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
