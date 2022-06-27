using FileReader.DataAccess;
using FileReader.DataAccess.Entities;
using FileReader.DataAccess.Repositories;

namespace FileReader.BusinessLogic
{    
    public class FileManager : IFileManager
    {

        private readonly IFileRepository fileRepository;

        public List<Folder> Folders { get; set; }
        public List<LocalFile> Files { get; set; }  
       
        public FileManager()
        {
            fileRepository = new FileRepository();
            Files = new List<LocalFile>();
            Folders = new List<Folder>();
        }
        public void RefreshDb(Folder folder)
        {           
            fileRepository.UpdateDbFiles(folder);                        
        }

        public Folder RetrieveDbFolder(string path)
        {
           return fileRepository.RetrieveFolder(path);
        }
        public List<Folder> ReadFolderFolders(string path)
        {
            var directories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

            foreach (var item in directories)
            {
                string name = Path.GetFileName(item);
                string fullPath = Path.GetFullPath(item);
                var folder = new Folder(name, fullPath);               
                var files = ReadFolderFiles(folder);
                Folders.Add(folder);
            }
            return Folders;
        }
        //private void ReadFiles()
        //{           

        //    foreach (var folder in Folders)
        //    {
        //        var files = Directory.GetFiles(folder.Path);


        //        foreach (string file in files)
        //        {
        //            var fileInfo = new FileInfo(file);
        //            var name = fileInfo.Name;
        //            var size = fileInfo.Length;
        //            var fullPath = Path.GetFullPath(file);
        //            var folderId = folder.Id;
        //            var newFile = new LocalFile(name, size, fullPath, folderId);
        //            Files.Add(newFile);
        //            folder.Files.Add(newFile);
        //        }  
        //    }
        //}
        public Folder RetrieveLocalFolder(string path)
        {
            var name = Path.GetFileName(path);
            var folder = new Folder(name, path);             
            var files = ReadFolderFiles(folder);
            folder.Folders = ReadFolderFolders(path); 
            folder.Files = files;
            return folder;
        }
       
        private List<LocalFile> ReadFolderFiles(Folder folder)
        {
            var files = Directory.GetFiles(folder.Path);

            foreach (string file in files)
            {
                var fileInfo = new FileInfo(file);
                var name = fileInfo.Name;
                var size = fileInfo.Length;
                var fullPath = Path.GetFullPath(file);
                var folderId = folder.Id;
                var newFile = new LocalFile(name, size, fullPath, folderId);
                Files.Add(newFile);
                folder.Files.Add(newFile);
            }
            return Files;
        }
    }
}
