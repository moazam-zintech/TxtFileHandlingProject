using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Xml.Linq;
using UserInfo.Operations;

namespace UserInfo.xUnitTests
{
    public class UnitTest1
    {
        SaveRecord saveRecord = new SaveRecord();
        GetRecord getRecord = new GetRecord();
        EditData editData = new EditData();
        ReadFile readFile = new ReadFile();
        DeleteFile deleteFile = new DeleteFile();

        UserInputs inputClass=new UserInputs();
        [Fact]
        public void Test1()
        {
            //Assign
            var name = "moazam";
            var address = "lahore";
            var phone = "03458";
            Int32 ID = 123;
            //Act 
            saveRecord.SaveInfo(ID, name, address, phone);
            getRecord.GetAllInfo();
            //Assert
            Assert.Equal(name, getRecord.Name);
            Assert.Equal(address, getRecord.Address);
            Assert.Equal(phone, getRecord.Phone);
            Assert.Equal(ID, getRecord.Id);
        }
        [Fact]
        public void Test2()
        {

        }

    }
}