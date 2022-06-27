﻿using FileReader.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader_BusinessLogic.Interfaces
{
    public interface IFileManager
    {
        List<Folder> Folders { get; }
        List<LocalFile> Files { get; }
        void RefreshDb(Folder folder);
        Folder RetrieveDbFolder(string path);
        Folder RetrieveLocalFolder(string path);

    }
}
