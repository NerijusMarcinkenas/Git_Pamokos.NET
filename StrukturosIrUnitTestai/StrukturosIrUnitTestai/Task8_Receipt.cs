using System;
using System.Collections.Generic;
using System.Text;

namespace StrukturosIrUnitTestai
{
    public struct Task8_Receipt
    {

        public string PayCheckID;
        public double Tottal;

        public Task8_Receipt(string payCheckID, double tottal)
        {
            PayCheckID = payCheckID;
            Tottal = tottal;
        }
    }
}
