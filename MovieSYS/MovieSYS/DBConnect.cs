using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSYS
{
    class DBConnect
    {
        // Replace the User ID "<user>" and Password "<pass>" with your own Oracle DB username and password.
        /* 
        The data source is set to the default hostname/IP address and Service Name. This can be changed to  
        the hostname/IP address and Service Name of your own Oracle Database server.
        */
        public const String oraDB = "Data Source = localhost/orcl; User Id = <user>; Password = <pass>;";
    }
}
