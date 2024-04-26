using System.Text;
using UserInfo.Interfaces;

namespace UserInfo.Operations
{
    public class ReadFile : UserInfoClass, IReadFile
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
        public string ReadFileData()
        {
            GlobalPath globalPath = new GlobalPath();
            string path = globalPath.GetPath();
            if (File.Exists(path))
            {
                return File.ReadAllText(path, Encoding.UTF8);
            }
            else
            {
                Console.WriteLine("There is no file");
                return "";
            }
        }
    }
}
