using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
           ISaveRecord savedRecord = new SaveRecord();
            IReadFile readFile = new ReadFile();
         
            //Console.WriteLine(".......................User Info..........................\n\n");
        
            UserInputs inputClass = new UserInputs(savedRecord, readFile);
            inputClass.Input();
           // testClass.List1();


            var serviceCollection=new ServiceCollection();

            IConfiguration configuration=new ConfigurationBuilder().SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName).AddJsonFile("appsettings.json").Build();
            serviceCollection.AddSingleton<IConfiguration>(configuration);
        }
    }
}