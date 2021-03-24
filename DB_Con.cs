using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Útnyílvántartás
{
    public static class DB_Con
    {
        public static string con_datasource = "127.0.0.1";
        public static string con_port = "3306";
        public static string con_username = "root";
        public static string con_password = "";
        public static string con_database = "utnyilvantartas";
        public static string constr = "datasource=" + con_datasource + ";port=" + con_port + ";username=" + con_username + ";password=" + con_password + ";database=" + con_database;
    }
}
