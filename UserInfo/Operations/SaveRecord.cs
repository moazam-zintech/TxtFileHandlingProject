using System.IO;
using System.Text;
using UserInfo.Interfaces;

namespace UserInfo.Operations
{
    public class SaveRecord : ISaveRecord
    {
        public void SaveInfo(int Id, string Name, string Address, string Phone,string tempFile)
        {
            using(StreamWriter sw = new StreamWriter(tempFile,true,Encoding.UTF8)) 
            {
                sw.WriteLine(Id+","+Name+","+Address + ","+Phone);
            }
        }
        public void EditRecord(int search,string editName,string editAddress,string editPhone)
        {
            string path = "file.txt";
            string tempFile = "temp.txt";
            List<string> records = new List<string>();
            records = (System.IO.File.ReadAllLines("file.txt")).ToList();
            for(int i=0;i<records.Count;i++)
            {
                string[] fields = records[i].Split(',');
                if (Int32.Parse(fields[0])==search)
                {
                    SaveInfo(Int32.Parse(fields[0]),editName,editAddress,editPhone,tempFile);
                    Console.WriteLine("Done");
                }
                else
                {
                    SaveInfo(Int32.Parse(fields[0]), fields[1], fields[2], fields[3], tempFile);
                }
            }
            File.Delete(path);
            File.Move(tempFile, path);
        }
        public void DeleteRecord(int search)
        {
            string path = "file.txt";
            string tempFile = "temp.txt";
            List<string> records = new List<string>();
            records = (System.IO.File.ReadAllLines("file.txt")).ToList();
            for (int i = 0; i < records.Count; i++)
            {
                string[] fields = records[i].Split(',');
                if (Int32.Parse(fields[0]) == search)
                {
                    Console.WriteLine("Deleted");
                }
                else
                {
                    SaveInfo(Int32.Parse(fields[0]), fields[1], fields[2], fields[3], tempFile);
                }
            }
            File.Delete(path);
            File.Move(tempFile, path);
        }

    }
}
