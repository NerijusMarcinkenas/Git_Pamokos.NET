using System;
using System.Collections.Generic;
using System.Text;

namespace StrukturosIrUnitTestai
{
    public struct Task8_Accounting
    {
        public List<Task8_Receipt> Receipt;

        //public Task8_Accounting(List<Task8_Receipt> receipt)
        //{
        //    Receipt = receipt;
        //}

        public void AllReceiptSum()
        {
           
            Console.WriteLine($"Viso yra {Receipt.Count}");
            double sum = 0;
            
            
            for (int i = 0; i < Receipt.Count; i++)
            {
                sum += Receipt[i].Tottal;
            }
            Console.WriteLine($"Cekiu suma {Math.Round(sum, 2)} Eur");
            Console.WriteLine();
        }

       

    }
}
