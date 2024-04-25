using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UserInfo.Interfaces;
using UserInfo.Operations;
namespace UserInfo
{
    public class UserInputs
    {
        private ISaveRecord _saveRecord;
        private IGetRecord _getRecord;
        
        private IReadFile _readFile;
        private IEditRecord _editRecord;
        private IDeleteFile _deleteFile;
       /* SaveRecord saveRecord = new SaveRecord();
        GetRecord getRecord = new GetRecord();
        EditData editData = new EditData();
        ReadFile readFile = new ReadFile();
        DeleteFile deleteFile = new DeleteFile();*/
        public UserInputs(ISaveRecord saveRecord, IGetRecord getRecord, IReadFile readFile, IEditRecord editRecord, IDeleteFile deleteFile)
        {
            this._saveRecord = saveRecord;
            this._getRecord = getRecord;
            this._readFile = readFile;
            this._editRecord = editRecord;
            this._deleteFile = deleteFile;
        }
        public void Input()
        {
            //this._saveRecord = saveRecord;
            Console.WriteLine(".......................................................................");
            Console.WriteLine("1 = create Record \t 2 = Dispaly Records \t 3 = Edit file \n4 = Read Complete File \t 4 = Delete File \t 5 = Exit program");
            Console.WriteLine("Enter:-\n");
            Int16 userCommand;
            bool parced = Int16.TryParse(Console.ReadLine(), out userCommand);

            if (!parced)
            {
                Console.WriteLine("Please only enter provided numbers");
                Input();
            }
            if (userCommand == 1)
            {
                Console.WriteLine("...............................Input...................................");
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("ID:");
                int ID = 0;
                bool okay = int.TryParse(Console.ReadLine(), out ID);
                if (!okay)
                {
                    Console.WriteLine("Please Enter Id in digits");
                    Input();
                }
                Console.WriteLine("Address");
                string address = Console.ReadLine();
                Console.WriteLine("Phone");
                string Phone = Console.ReadLine();
                _saveRecord.SaveInfo(ID, name, address, Phone);
                Input();
            }
            else if (userCommand == 2)
            {
                Console.WriteLine("...............................Output..................................");
                _getRecord.GetAllInfo();
                Input();
            }
            else if (userCommand == 3)
            {
                Console.WriteLine("Please write additional details in the file:");
                string details = Console.ReadLine();
                _editRecord.EditRecord(details);
                Input();
            }
            else if (userCommand == 4)
            {
                Console.WriteLine(_readFile.ReadFileData());
                Input();
                }
            else if (userCommand == 5)
                {
                    _deleteFile.DeleteFileData();
                    Input();
                }
                else if (userCommand == 6)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter provided numbers");
                }
            }
        }
}
