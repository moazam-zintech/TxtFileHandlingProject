using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfo.Interfaces;

namespace UserInfo.Operations
{
    public class ReadFile: IReadFile
    {
        public string ReadFileData()
        {
            
            GlobalPath globalPath = new GlobalPath();
            string path = globalPath.GetPath();
            if(File.Exists(path))
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
