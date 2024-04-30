using Castle.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfo
{
    public class Test
    {
        IConfiguration _configuration;
        public Test(IConfiguration configuration) {

            this._configuration = configuration;
                }

        public void Function()

        {
           // var path = _configuration.GetValue<string>("FilePath");
        }
    }
}
