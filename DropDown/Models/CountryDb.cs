using DropDown.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DropDown.Models
{
    public class CountryDb
    {
        private DbCinfig db =new DbCinfig();

        public List<Country> GetAllCountry()
        {
            SqlCommand cmd = new SqlCommand("spCountries", db.sql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            if (db.sql.State == System.Data.ConnectionState.Closed)
                db.sql.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Country> CountryList = new List<Country>();
            while (reader.Read())
            {
                Country objcountry = new Country();
               objcountry.CoId= (int)reader[0];
                objcountry.Name= reader[1].ToString();
                CountryList.Add(objcountry);
            }
            db.sql.Close();
            return CountryList;
        }


    }
}