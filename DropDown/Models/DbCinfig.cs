using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DropDown.Models
{
    public class DbCinfig
    {

        public SqlConnection sql { get; }
        public DbCinfig()
        {
            string cnn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            sql = new SqlConnection(cnn);
        }
    }
}


    
