using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfo.Operations
{
    public class DeleteFile: UserInfoClass
    {
        public void DeleteFileData()
        {
            //  File.Delete(path);
            File.WriteAllText(path, string.Empty);
            Console.WriteLine("File Deleted Successfully\n");
        }
    }
}
