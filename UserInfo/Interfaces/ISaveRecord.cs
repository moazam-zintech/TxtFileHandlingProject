using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfo.Interfaces
{
    public interface ISaveRecord
    {
        public void SaveInfo(int Id,string Name,string Address,string Phone,string tempFile);
        public void EditRecord(int details, string editName, string editAddress, string editPhone);
        public void DeleteRecord(int search);

    }
}
