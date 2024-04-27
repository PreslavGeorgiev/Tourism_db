using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism_db
{
    public partial class MainMenu : Form
    {
        public MainMenu(bool showAdminButton)
        {
            InitializeComponent();
            if (!showAdminButton)
            {
                adminButton.Visible = false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Countries2;Integrated Security=True;");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT CountriesID, CountryName FROM Countries", con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable countriesTable = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(countriesTable);

            comboBox1.DataSource = countriesTable;
            comboBox1.DisplayMember = "CountryName";
            comboBox1.ValueMember = "CountriesID";

            cmd = new SqlCommand("SELECT TownsID,Town_Name FROM Towns", con);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable townsTable = new DataTable();
            adapter.Fill(townsTable);

            comboBox2.DataSource = townsTable;
            comboBox2.DisplayMember = "Town_Name";
            comboBox2.ValueMember = "TownsID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel form1 = new AdminPanel();
            form1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
