using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MakelYemekhaneWebService
{
    public class DBHelper
    {
        string connstring = @"server=localhost;user=sa;password=1234;database=yemekhane";
        SqlConnection conn = null;

        public DBHelper()
        {
            conn = new SqlConnection(connstring);
           
        }



        public List<GunlukMenu> getAllGunlukMenu()
        {
            try
            {
                List<GunlukMenu> listGunlukMenu = new List<GunlukMenu>();

                conn.Open();
                string query = "SELECT * FROM yemek;";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "yemek");
                DataTable dt = ds.Tables["yemek"];

                foreach (DataRow row in dt.Rows)
                {
                    // var dateAndTime = (DateTime)row[0];
                    // var date = dateAndTime.ToShortDateString();
                    // GunlukMenu gunlukMenu = new GunlukMenu(date);

                    GunlukMenu gunlukMenu = new GunlukMenu((DateTime)row[0]);
                    gunlukMenu.yemek1 = row[1].ToString();
                    gunlukMenu.yemek2 = row[2].ToString();
                    gunlukMenu.yemek3 = row[3].ToString();
                    gunlukMenu.yemek4 = row[4].ToString();
                    gunlukMenu.yemek5 = row[5].ToString();

                    listGunlukMenu.Add(gunlukMenu);
                }
                return listGunlukMenu;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }       
    }
}