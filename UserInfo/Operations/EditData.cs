using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfo.Operations
{
    public class EditData: UserInfoClass
    {
        public void EditRecord(string details)
        {
            File.AppendAllText(path, details, Encoding.UTF8);
        }
    }
}
