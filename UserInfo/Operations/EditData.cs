using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfo.Interfaces;

namespace UserInfo.Operations
{
    public class EditData: IEditRecord
    {
        string path = @"D:\Rough Folder\UserInfo\UserInfo\Mytest.txt";
        public void EditRecord(string details)
        {
            File.AppendAllText(path, details, Encoding.UTF8);
        }
    }
}
