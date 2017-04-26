using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerInventory
{
    class cmdb
    {
        public static ServerInfo AddServer(string servername,string servicename,string forestname,int isactive)
        {
            var serverinfo = new ServerInfo(servername, servicename, forestname, isactive);
            return serverinfo;


        }

    }
}
