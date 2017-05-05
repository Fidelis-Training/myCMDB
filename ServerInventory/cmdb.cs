using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerInventory
{
    class cmdb
    {

        private static List<ServerInfo> serverinfos = new List<ServerInfo>();
        public static ServerInfo AddServer(string servername, ServiceNames servicename,string forestname,int isactive)
        {
            var serverinfo = new ServerInfo(servername, servicename, forestname, isactive);
            serverinfos.Add(serverinfo);
            return serverinfo;


        }

        public static List<ServerInfo> GetAllServerInfo()
        {

            return serverinfos;
        }

    }
}
