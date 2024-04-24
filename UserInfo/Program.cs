using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace UserInfo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Save
            //Get All(Display all)
            //Edit
            //Delete
            Console.WriteLine(".......................User Info..........................\n\n");
            InputClass inputClass = new InputClass();
            inputClass.Input();

            /*      userInfoClass.SetId(id);
            userInfoClass.SetName(name);
            userInfoClass.Saveinfo();
*/
            /*  BinaryWriter bw;
              BinaryReader br;
              try
              {
                  bw = new BinaryWriter(new FileStream("userInfoData", FileMode.Create));
              }
              catch (IOException e)
              {
                  Console.WriteLine(e.Message,"Can not create file");
                  return;
               }
             try
              {
                  bw.Write(id);
                  bw.Write(name);
              }
              catch (Exception e)
              {
                  Console.WriteLine(e.Message, "Can not store");
                  return;
              }
              bw.Close();
              try
              {
                  br = new BinaryReader(new FileStream("userInfoData", FileMode.Open));
              }
              catch (Exception)
              {
                  throw;
              }
              string i;
              try
              {
                  id = br.ReadInt32();
                  i = br.ReadString();
              }
              catch (Exception)
              {
                  throw;
              }

              try
              {

              }
              catch (Exception)
              {
                  throw;
              }

              string j = name;
              int i1 = id;*/
        }
    }
}