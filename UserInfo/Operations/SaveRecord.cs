using System.Text;
using UserInfo.Interfaces;

namespace UserInfo.Operations
{
    public class SaveRecord : ISaveRecord
    {
        public void SaveInfo()
        {
            GlobalPath globalPath = new GlobalPath();
            string path = globalPath.GetPath();
            UserInfoClass user= new UserInfoClass();
            if (File.Exists(path))
            {
                using (var stream = File.Open(path, FileMode.OpenOrCreate))
                {
                    using (var bw = new BinaryWriter(stream, Encoding.UTF8))
                    {
                        bw.Write(user.Id);
                        bw.Write(user.Name);
                        bw.Write(user.Address);
                        bw.Write(user.Phone);
                    }
                }
                Console.WriteLine("File is created and Record is added:");
            }
        }
        public void EditRecord(string details)
        {
            GlobalPath globalPath = new GlobalPath();
            string path = globalPath.GetPath();
            File.AppendAllText(path, details, Encoding.UTF8);
        }
    }
}
