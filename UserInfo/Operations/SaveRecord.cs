using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfo.Interfaces;

namespace UserInfo.Operations
{
    public class SaveRecord: ISaveRecord
    {
        public void SaveInfo(int id, string name, string address, string phone)
        {
            GlobalPath globalPath = new GlobalPath();
            string path = globalPath.GetPath();
           // string path = @"D:\Rough Folder\UserInfo\UserInfo\Mytest.txt";
            if (!File.Exists(path))
            {
                using (var stream = File.Open(path, FileMode.OpenOrCreate))
                {
                    using (var bw = new BinaryWriter(stream, Encoding.UTF8))
                    {
                        bw.Write(id);
                        bw.Write(name);
                        bw.Write(address);
                        bw.Write(phone);
                    }
                }
                Console.WriteLine("File is created and Record is added:");
            }
        }
    }
}
