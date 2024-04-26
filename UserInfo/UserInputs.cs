using UserInfo.Interfaces;
namespace UserInfo
{
    public class UserInputs
    {
        private ISaveRecord _saveRecord;
        private IReadFile _readFile;
        UserInfoClass user = new UserInfoClass();
        public UserInputs(ISaveRecord saveRecord, IReadFile readFile)
        {
            this._saveRecord = saveRecord;
            this._readFile = readFile;
          
        }
        public void Input()
        {
            Console.WriteLine(".......................................................................");
            Console.WriteLine("1 = create Record \t 2 = Dispaly Records \t 3 = Edit file \n4 = Read Complete File \t 5 = Exit program");
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
                string name= Console.ReadLine();
                
                user.Name = "Naveed";

                Console.WriteLine("ID:");
                int ID = 0;
                bool okay = int.TryParse(Console.ReadLine(), out ID);
                if (!okay)
                {
                    Console.WriteLine("Please Enter Id in digits");
                    Input();
                }
                user.Id = 123;
                Console.WriteLine("Address");
                user.Address = "karachi"; //= Console.ReadLine();
                Console.WriteLine("Phone");
                user.Phone = "03456666";//= Console.ReadLine();
                _saveRecord.SaveInfo();
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
                string details = Console.ReadLine();
                _saveRecord.EditRecord(details);
                Input();
            }
            else if (userCommand == 4)
            {
                Console.WriteLine(_readFile.ReadFileData());
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
