using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfo.Interfaces;

namespace UserInfo.Operations
{
    public class DeleteFile: IDeleteFile
    {
        public void DeleteFileData()
        {
            string path = @"D:\Rough Folder\UserInfo\UserInfo\Mytest.txt";
            //  File.Delete(path);
            File.WriteAllText(path, string.Empty);
            Console.WriteLine("File Deleted Successfully\n");
        }
    }
}
