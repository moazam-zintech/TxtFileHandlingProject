using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfo.Interfaces;

namespace UserInfo.Operations
{
    public class ReadFile: IReadFile
    {
        public string ReadFileData()
        {
            return File.ReadAllText(@"D:\Rough Folder\UserInfo\UserInfo\Mytest.txt", Encoding.UTF8);
        }
    }
}
