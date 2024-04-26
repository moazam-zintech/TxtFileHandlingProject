using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UserInfo.Interfaces;

namespace UserInfo
{
    public class GetRecord: UserInfoClass,IGetRecord
    {
       public void GetAllInfo()
        {
            GlobalPath globalPath = new GlobalPath();
            string path = globalPath.GetPath();
           // string path = @"D:\Rough Folder\UserInfo\UserInfo\Mytest.txt";
            if (File.Exists(path) && !(File.ReadAllText(path) == ""))
            {
                using (var stream = File.Open(path, FileMode.Open))
                {
                    using (var br = new BinaryReader(stream, Encoding.UTF8))
                    {
                        Id = br.ReadInt32();
                        Name = br.ReadString();
                        Address = br.ReadString();
                        Phone = br.ReadString();
                    }
                }
            }
            Console.WriteLine("Id: " + Id + "\nName:" + Name + "\nAddress: " + Address + "\nAddress: " + Phone);
        }
    }
}
