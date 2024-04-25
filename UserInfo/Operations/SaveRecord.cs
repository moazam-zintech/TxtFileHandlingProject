using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfo.Operations
{
    public class SaveRecord
    {
        public void SaveInfo(int id, string name, string address, string phone)
        {
            string path = @"D:\Rough Folder\UserInfo\UserInfo\Mytest.txt";
            if (!File.Exists(path))
            {
                using (var stream = File.Open(path, FileMode.Create))
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
            else
            {
                using (var stream = File.Open(path, FileMode.Open))
                {
                    using (var bw = new BinaryWriter(stream, Encoding.UTF8))
                    {
                        bw.Write(id);
                        bw.Write(name);
                        bw.Write(address);
                        bw.Write(phone);
                    }
                }
                Console.WriteLine("Record is added in existing file");
            }
        }
    }
}
