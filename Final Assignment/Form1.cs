using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalAssinment
{
    public partial class allbooks : Form
    {
        Book_detail book_Detail = new Book_detail();
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F9IRGFB;Initial Catalog=Book;Integrated Security=True");
        public allbooks()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("SELECT * FROM Book WHERE ID= "+int.Parse(textBox1.Text),con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = (dr["Name"].ToString());
                textBox3.Text = (dr["Author"].ToString());
              textBox4.Text = (dr["Edition"].ToString());
            }
            else
            {
                textBox2.Text = ("");
                textBox3.Text = ("");
                textBox4.Text = ("");
                MessageBox.Show("No Book found");
            }
            
            con.Close();
        }
        private void allbooks_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
            book_Detail.show1();
            book_Detail.Show();
            Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            book_Detail.show2();
            book_Detail.Show();
            Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            book_Detail.show3();
            book_Detail.Show();
            Hide();
        }
    }
}
