using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.Created += (o, e) => Console.WriteLine("Created: " + e.FullPath);
            w.Deleted += (o, e) => Console.WriteLine("Deleted: " + e.FullPath);
            w.Renamed += (o, e) => Console.WriteLine("Renamed: " + e.FullPath);
            w.Changed += (o, e) => Console.WriteLine("Changed: " + e.FullPath);

            do { } while (true);

        }


    }
}
