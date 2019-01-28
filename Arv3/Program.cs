﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                StockItem s = new StockItem(-1);

            }
            catch (StockItemException ex)
            {
                Console.WriteLine("StockItem Error : " + ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("General Error");
            }




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class StockItem
    {
        public int ID{ get; set;}

        public StockItem(int id)
        {
            if (id < 0)
                throw new StockItemException("Wrong ID");
        }
    }


    public class StockItemException : Exception
    {
        public StockItemException(string message) : base(message)
        {
        }

    }
}
