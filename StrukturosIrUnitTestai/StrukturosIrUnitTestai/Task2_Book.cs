using System;
using System.Collections.Generic;
using System.Text;

namespace StrukturosIrUnitTestai
{
    class Task2_Book
    {
        public int ID;
        public string Tittle;
        public string ReaderName;
        public DateTime DateTaken;
        public DateTime Today = DateTime.Now.Date;
        

        public Task2_Book(int iD, string tittle, string readerName, DateTime dateTaken)
        {
            ID = iD;
            Tittle = tittle;
            ReaderName = readerName;
            DateTaken = dateTaken;       
        }

        public TimeSpan GetDays(DateTime dateTaken)
        {
           return Today - dateTaken;
        }

    }
}
