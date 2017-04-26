using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerInventory
{

    /// <summary>
    /// Servers information
    /// </summary>
    class ServerInfo
    {
        #region Variables
        private static int LastServerId = 0;
        #endregion

        #region constructors
        /// <summary>
        /// This constructor is built to get all the data and its varaibles for the serverinfo class
        /// </summary>
        public ServerInfo()
        {
            ServerId = ++LastServerId;

        }

        public ServerInfo(string servername) : this()
        {
            ServerName = servername;
        }

        public ServerInfo(string servername,string servicename) : this(servername)
        {
            ServiceName = servicename;
        }

        public ServerInfo(string servername, string servicename, string forestname) : this(servicename)
        {
            ForestName = forestname;
        }

        public ServerInfo(string servername, string servicename, string forestname, int isactive) : this(forestname)
        {
            IsActive = isactive;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Server Properties
        /// </summary>

        public int ServerId { get; private set; }
        public string ServerName { get; set; }

        public string ServiceName { get; set; }

        public string ForestName { get; set; }

        public int IsActive { get; set; }

        #endregion

        
    }
}
