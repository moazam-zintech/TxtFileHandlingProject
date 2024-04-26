using System.Text;
using UserInfo.Interfaces;

namespace UserInfo.Operations
{
    public class SaveRecord : ISaveRecord
    {

        
        public void SaveInfo(int id, string name, string address, string phone)
        {
            GlobalPath globalPath = new GlobalPath();
            string path = globalPath.GetPath();
            if (File.Exists(path))
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
        public void EditRecord(string details)
        {
            GlobalPath globalPath = new GlobalPath();
            string path = globalPath.GetPath();
            File.AppendAllText(path, details, Encoding.UTF8);
        }
    }
}
