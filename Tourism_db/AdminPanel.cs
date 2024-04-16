using Microsoft.Data.SqlClient;
using System.Data;

namespace Tourism_db
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC13\SQLEXPRESS;Initial Catalog=Countries1;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Towns(TownsID, Town_Name) Values (@ID,@city)", con);
            cmd.Parameters.AddWithValue("@city", textBox2.Text);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was inserted.");
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC13\SQLEXPRESS;Initial Catalog=Countries1;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Towns SET Town_Name=@city WHERE TownsID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@city", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was updated.");
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC13\SQLEXPRESS;Initial Catalog=Countries1;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE from Towns WHERE TownsID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was deleted.");
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC13\SQLEXPRESS;Initial Catalog=Countries1;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT TownsID, Town_Name from Towns", con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable townsTable = new DataTable();

            adapter.Fill(townsTable);

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC13\SQLEXPRESS;Initial Catalog=Countries1;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Countries(CountriesID, CountryName) VALUES (@ID,@Country)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Country", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was inserted.");
        }
    }
}
