using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfo.Operations
{
    public class ReadFile: UserInfoClass
    {
        public string ReadFileData()
        {
            return File.ReadAllText(@"D:\Rough Folder\UserInfo\UserInfo\Mytest.txt", Encoding.UTF8);
        }
    }
}
