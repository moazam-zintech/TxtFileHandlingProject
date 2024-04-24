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
namespace UserInfo
{
    public class UserInfoClass
    {
        public string Name { get; set; }
        public Int32 Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        string path = @"D:\Rough Folder\UserInfo\UserInfo\Mytest.txt";
       // string path1 = @"D:\Rough Folder\UserInfo\UserInfo\bin\debug\net8.0\UserInfoFile.txt";

        public void SaveInfo(int id, string name, string address, string phone)
        {
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
            }
        }
        public void GetAllInfo()
        {
            if (File.Exists(path))
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
        public void EditRecord(int id, string name, string address, string phone)
        {
           File.AppendAllText(path,"This is something new");
        }
        public void DeleteFile()
        {
            File.Delete(path);
            Console.WriteLine("File Deleted Successfully\n");
        }
    }
}
