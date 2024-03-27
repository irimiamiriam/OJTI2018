using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJTI2018.DataBase
{
    class SqlAccess
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        public static string GetFilePath()
        {
            return ConfigurationManager.AppSettings["DateFile"];
        }

    }
}
