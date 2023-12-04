using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using BAL;

namespace Client_base
{
    internal class Retrival
    {
        public static string path;
        private static string connection()
        {
            StreamReader re = new StreamReader("supermarket.txt");
            while (!re.EndOfStream)
            {
                path = re.ReadLine();
            }
            re.Close();
            return path;
        }
        public static SqlConnection con = new SqlConnection(connection());
        public static void getbranch(DataGridView gv, DataGridViewColumn IDGV, DataGridViewColumn NameGV,DataGridViewColumn ID,DataGridViewColumn NAME)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("st_getbranch", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                IDGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["NAME"].ToString();
                ID.DataPropertyName = dt.Columns["BRANCH ID"].ToString();
                NAME.DataPropertyName = dt.Columns["BRNCH NAME"].ToString();
                gv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public static void getRoles(DataGridView gv, DataGridViewColumn IDGV, DataGridViewColumn NameGV, DataGridViewColumn ID, DataGridViewColumn NAME)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("st_getroles", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                IDGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["NAME"].ToString();
                ID.DataPropertyName = dt.Columns["COMPANY ID"].ToString();
                NAME.DataPropertyName = dt.Columns["COMPANY NAME"].ToString();
                gv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public static bool isValidUser(string user, string pass)
        {
            bool status = false;
            try
            {

                SqlCommand cmd = new SqlCommand("st_getuser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (user == reader["Name"].ToString() && pass == reader["Key"].ToString())
                        {
                            MessageBox.Show("SuccessFully");

                        }
                        else
                        {
                            MessageBox.Show("Invalid User and Password ", "Error");
                            status = false;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User and Password ", "Error");
                    status = false;

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                con.Close();
            }
            return status;
        }
    }
}
