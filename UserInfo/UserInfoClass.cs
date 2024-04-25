using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UserInfo.Operations;
namespace UserInfo
{
    public class UserInfoClass
    {
        public string Name { get; set; }
        public Int32 Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
       public string path = @"D:\Rough Folder\UserInfo\UserInfo\Mytest.txt";
       
    }
}
