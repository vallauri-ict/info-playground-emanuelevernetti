using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace esercizioTriggerCorrezione
{
    public partial class FormMain : Form
    {
        private static string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=" + Directory.GetCurrentDirectory() + @"\DBesercizioTrigger.mdf;Integrated Security=True";

        private BindingSource bsDriver = new BindingSource();
        private BindingSource bsStoricoCancellazioni = new BindingSource();
        private BindingSource bsStoricoAggiornamenti = new BindingSource();
        private DataTable dtDriver, dtStoricoCancellazioni, dtStoricoAggiornamenti;
        private SqlDataAdapter daDriver, daStoricoCancellazioni, daStoricoAggiornamenti;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PopulateDgv(0);
        }

        private void btnES1_Click(object sender, EventArgs e)
        {
            string country = Interaction.InputBox("Inserisci country");
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING);
            string sql = "SELECT * FROM ES1('" + country + "')";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            sqlConnection.Close();
            da.Dispose();
            dgvDriver.DataSource = dt;
        }

        private void btnES2_Click(object sender, EventArgs e)
        {
            int podiumsNumber = int.Parse(Interaction.InputBox("Inserisci numero di podi"));
            SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING);
            string sql = "SELECT dbo.ES2(" + podiumsNumber + ")";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show("Numero piloti: "+reader.GetInt32(0).ToString());
            }
            sqlConnection.Close();
        }

        private void Query(string selectCommand, out SqlDataAdapter da)
        {
            da = null;
            try
            {
                //Creo un nuovo data adapter basato su selectCommand
                da = new SqlDataAdapter(selectCommand, CONNECTION_STRING);

                //Creo un command builder per generare un comando SQL update, insert, delete
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateDgv(int tables)
        {
            switch (tables)
            {
                case 0:
                {
                    //Driver
                    dgvDriver.DataSource = bsDriver;
                    Query("SELECT * FROM Driver", out daDriver);
                    if (daDriver != null)
                    {
                        dtDriver = new DataTable();
                        daDriver.Fill(dtDriver);
                        bsDriver.DataSource = dtDriver;
                    }

                    dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
                }
            }
        }
    }
}
