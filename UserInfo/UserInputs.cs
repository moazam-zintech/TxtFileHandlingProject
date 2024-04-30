using Castle.Components.DictionaryAdapter.Xml;
using Castle.Core.Configuration;
using UserInfo.Interfaces;
namespace UserInfo
{
    public class UserInputs
    {
        private ISaveRecord _saveRecord;
        private IReadFile _readFile;
        UserInfoClass user = new UserInfoClass();
        private readonly IConfiguration configuration;
   
        public UserInputs(ISaveRecord saveRecord, IReadFile readFile)
        {
            this._saveRecord = saveRecord;
            this._readFile = readFile;
        }
        public void Input()
        {
           // var path = configuration.GetValue<string>("FilePath");
            Console.WriteLine(".......................................................................");
            Console.WriteLine("1 = create Record \t 2 = Dispaly Records \t 3 = Edit file \n 4 = Delete Record \t 5 = Exit program");
            Console.WriteLine("Enter:");
           
            Int16 userCommand;
            bool parced = Int16.TryParse(Console.ReadLine(), out userCommand);
            if (!parced)
            {
                Console.WriteLine("Please only enter provided numbers");
                Input();
            }
            if (userCommand == 1)
            {
                Console.WriteLine("ID:");
                int ID;
                bool okay = int.TryParse(Console.ReadLine(), out ID);
                if (!okay)
                {
                    Console.WriteLine("Please Enter Id in digits");
                    Input();
                }
                user.Id = ID;
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
               user.Name = name;
                Console.WriteLine("Address");
               user.Address = Console.ReadLine();
                Console.WriteLine("Phone");
               user.Phone = Console.ReadLine();
                _saveRecord.SaveInfo(user.Id,user.Name,user.Address,user.Phone, @"file.txt");
                Input();
            }
            else if (userCommand == 2)
            {
                Console.WriteLine("...............................Output..................................");
                _readFile.GetAllInfo();
                Input();
            }
            else if (userCommand == 3)
            {
                Console.WriteLine("Please write additional details in the file:");
                int details = Int32.Parse(Console.ReadLine());

                string editName = "Edit Name";
                string editAddress = "EDit Address";
                string editPhone = "Edit Phone";

                _saveRecord.EditRecord(details, editName, editAddress,editPhone);
                Input();
            }
            else if (userCommand == 4)
            {
                Console.WriteLine("Enter record's ID to delete:");
                int searchId=int.Parse(Console.ReadLine());
                _saveRecord.DeleteRecord(searchId);
                Input();
            }
            else if (userCommand == 5)
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
