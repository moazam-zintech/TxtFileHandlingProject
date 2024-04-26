using Moq;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using UserInfo.Interfaces;
using UserInfo.Operations;
namespace UserInfo.xUnitTests
{
    public class UnitTest1
    {
        SaveRecord saveRecord = new SaveRecord();
        ReadFile readFile = new ReadFile();
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

            readFile.GetAllInfo();
            //Assert
            Assert.Equal(name, readFile.Name);
            Assert.Equal(address, readFile.Address);
            Assert.Equal(phone, readFile.Phone);
            Assert.Equal(ID, readFile.Id);
        }
        [Fact]
        public void ReadFileTest()
        {
            readFile.ReadFileData();
        }
     
  
        [Fact]
        //Mock Test
        public void mockTest()
        {
            var getRecord=new Mock<IReadFile>();
            var data=getRecord.Setup(x => x.GetAllInfo());
            Assert.NotNull(data);
        }
    }
}