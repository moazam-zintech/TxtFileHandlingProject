using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfo.Interfaces
{
    public interface ISaveRecord
    {
        public void SaveInfo(int id, string name, string address, string phone);
        public void EditRecord(string details);

    }
}
