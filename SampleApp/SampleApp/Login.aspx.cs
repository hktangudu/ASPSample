using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SampleApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DBCode();
        }


        private void DBCode()
        {
            SqlConnection connection = new SqlConnection("server = .\\sqlexpress;database = CMS; uid = sa; password = pass@word1");

            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "select count(*) from Student";

                cmd.Connection.Open();

                int result = (int)cmd.ExecuteScalar();

                //txtUName.Text = result.ToString();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cmd.Connection != null && cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }

        }
    }
}