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
            return File.ReadAllText(path, Encoding.UTF8);
        }
    }
}
