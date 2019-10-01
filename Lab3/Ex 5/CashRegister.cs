using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5
{
  public  class CashRegister
    {
        public static double totalAllReg { get; set; }

        public static int totalItemsAllReg { get; set; }
        public int NumberOfItems { get; private set; }

        public double Total { get; private set; }

        public void AddItem(double itemprice)
        {
            Total += itemprice;
            NumberOfItems++;

            totalItemsAllReg++;
            totalAllReg += itemprice;
        }
    }
}
