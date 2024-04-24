using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Xml.Linq;

namespace UserInfo.xUnitTests
{
    public class UnitTest1
    {
        //UserInfoClass userInfo = new UserInfoClass();
        InputClass inputClass=new InputClass();
        [Fact]
        public void Test1()
        {
            //Assign
            var name = "moazam";
            var address = "lahore";
            var phone = "03458";
            int ID = 123;
            //Act 
            inputClass.SaveInfo(ID, name, address, phone);
            ID = 234243;
            //Assert
            Assert.Equal(name, inputClass.Name);
            Assert.Equal(address, inputClass.Address);
            Assert.Equal(phone, inputClass.Phone);
            Assert.Equal(ID, inputClass.Id);
        }
        [Fact]
        public void Test2()
        {
            //Assign
            var name = "moazam";
            var address = "lahore";
            var phone = "03458";
            int ID = 123;
            //Act 
            inputClass.SaveInfo(ID, name, address, phone);
            inputClass.GetAllInfo();
            Assert.Equal(phone, inputClass.Phone);
            Assert.Equal(ID, inputClass.Id);
        }
    }
}