using FileReader.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader_DataAccess.Interfaces
{
    public interface IFileRepository
    {
        void UpdateDbFiles(Folder folder);
        Folder RetrieveFolder(string path);
        void AddFolder(Folder folder);


    }
}
