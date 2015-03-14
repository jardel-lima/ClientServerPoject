using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientServerProject
{
    class DBconnect
    {
        public string host, uid, database, password;

        public override string ToString()
        {
            string connectionString;

            connectionString = "SERVER=" + host + ";DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            return connectionString;
        }
    }
}
