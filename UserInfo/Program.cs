using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using UserInfo.Interfaces;
using UserInfo.Operations;

namespace UserInfo
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            SaveRecord savedRecord = new SaveRecord();
            GetRecord record = new GetRecord();
           ReadFile readFile = new ReadFile();
            EditData editData = new EditData();
            DeleteFile deleteFile = new DeleteFile();
            Console.WriteLine(".......................User Info..........................\n\n");
            //Method Injections
            UserInputs inputClass = new UserInputs(savedRecord, record, readFile, editData, deleteFile);
            inputClass.Input();
        }
    }
}