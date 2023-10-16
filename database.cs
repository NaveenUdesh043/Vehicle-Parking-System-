using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Vehicle_Parking_System
{
    class database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public database() 
        {
            con = new SqlConnection("Data Source=DESKTOP-8CGRU93;Initial Catalog=parkingvehicle;Integrated Security=True");
        }
        
        public void openConnection()
        {
            con.Open();
        }
        public void closeConnection()
        {
            con.Close();
        }
        public DataTable getData(string a)
        {
            con.Open();
            da = new SqlDataAdapter(a, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close ();
            return dt;
        }
        public int save_update_delete(string a)
        {
            con.Open();
            cmd = new SqlCommand(a, con);
            int i = cmd.ExecuteNonQuery();
           con.Close();
            return i;
        }

        public int CheckLogin(string q)
        { 
            con.Open();
            da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.ToString() == "1")
            {
                con.Close();
                return 1;

            }
            else
            {
             con.Close();
                return 0; 
            }
               


        }
    }
}
