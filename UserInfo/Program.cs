using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using UserInfo.Interfaces;
using UserInfo.Operations;
using UserInfo.TestClassess;

namespace UserInfo
{
    public class Program
    {
        public static void Main(string[] args)
        { 
           ISaveRecord savedRecord = new SaveRecord();
            IGetRecord record = new GetRecord();
            IReadFile readFile = new ReadFile();
            EditData editData = new EditData();
            /*  IDeleteFile deleteFile = new DeleteFile();*/
            //Console.WriteLine(".......................User Info..........................\n\n");
            //Method Injections
            UserInputs inputClass = new UserInputs(savedRecord, record, readFile, editData);
            inputClass.Input();


            TestClass testClass = new TestClass();
           // testClass.List1();


        }
    }
}