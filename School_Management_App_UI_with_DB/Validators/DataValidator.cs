using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace School_Management_App_GUI_with_DB.NewFolder
{
    public class DataValidator
    {
        
        public static bool IsDateAvailbale(DateTime date, string connString)
        {
            using(var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string queryString = "SELECT date FROM  attendence";
                    using (var cmd = new NpgsqlCommand(queryString, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime datefromDB = Convert.ToDateTime(reader["date"]);
                            if (datefromDB.Date == date.Date)
                            {
                                return false;// data exists
                            }
                           
                        }
                    }
                    return true; // date not found

                }
                catch(Exception ex)
                {
                    MessageBox.Show("error: " + ex);
                    return false; //error , date not available
                }
            }
        }
    }
}
