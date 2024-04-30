using System.Text;
using UserInfo.Interfaces;
namespace UserInfo.Operations
{
    public class ReadFile : UserInfoClass, IReadFile
    {
        public void GetAllInfo()
        {
            List<string> records = new List<string>();
            records = (System.IO.File.ReadAllLines("file.txt",Encoding.UTF8)).ToList();
            for (int i = 0; i < records.Count; i++)
            {
                string[] strings = records[i].Split(",");
                Console.WriteLine(strings[0]+" "+ strings[1]+ " " + strings[2]+ " " + strings[3]);
            }
        }
    }
}
