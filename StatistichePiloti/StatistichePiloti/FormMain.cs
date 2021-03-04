using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatistichePiloti
{
    public partial class FormMain : Form
    {
        private static string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=" + Directory.GetCurrentDirectory() + @"\FormulaOne.mdf;Integrated Security=True";

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);

            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            {
                con.Open();
                string sql = "generaStatistiche";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlParameter driverId = new SqlParameter();
                driverId.ParameterName = "driverID";
                driverId.Direction = ParameterDirection.Input;
                driverId.DbType = DbType.Int32; //Tipo di dato nella S.P.
                driverId.Value = id;
                cmd.Parameters.Add(driverId);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
            }
        }
    }
}
