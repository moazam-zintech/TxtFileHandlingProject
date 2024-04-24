using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserInfo
{
    public class InputClass: UserInfoClass
    {
        UserInfoClass userInfoClass = new UserInfoClass();
       
        public void Input()
        {
            Console.WriteLine("...............................................................");
            Console.WriteLine("Enter 1 to create Record, Enter 2 to Dispaly Records, 3 to Exit");
            int userCommand = int.Parse(Console.ReadLine());



            //userCommand = int.Parse(userCommand1);

            if(userCommand == 0)
            {
                userInfoClass.SaveInfo(123,"Ali","MyAddress", "034523232323");
                Input();
            }
           
            if (userCommand == 1)
            {
                Console.WriteLine("...............................Input...............................");
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("ID:");
                int ID=int.Parse(Console.ReadLine());
                Console.WriteLine("Address");
                string address=Console.ReadLine();
                Console.WriteLine("Phone");
                string Phone=Console.ReadLine();
                userInfoClass.SaveInfo(ID,name,address,Phone);
                Input();
            }
            else if (userCommand == 2)
            {
                Console.WriteLine("...............................Output..............................." );
                userInfoClass.GetAllInfo();
                Input();
            }
            else if(userCommand==3)
            {
                userInfoClass.EditRecord(123333, "Ali333333", "MyAddress3333333", "034523232323333333");

                Input();
            }
            else if (userCommand == 4)
            {
                userInfoClass.DeleteFile();
                Input();
            }
            else if(userCommand==5)
            {
                Console.WriteLine(userInfoClass.ReadFile());
                      Input();
                
            }
            else if (userCommand == 6)
            {
                System.Environment.Exit(0);
            }
        }
        
    }
}
