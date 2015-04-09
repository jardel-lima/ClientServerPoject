/*
Cliente Server Final Project - Winter 2015

Jardel Lima - 300219631
Marcelle Amorim - 300227420
Weslley Kelson - 300227439
Rhafael Pinheiro - 300227431
 
Database account: f2014_user24
 */
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
