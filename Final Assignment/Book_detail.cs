using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace FinalAssinment
{
    public partial class Book_detail : Form
    {
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F9IRGFB;Initial Catalog=Book;Integrated Security=True");
        public void show1()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Book WHERE ID= " + 1, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void show2()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Book WHERE ID= " + 2, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void show3()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Book WHERE ID= " + 3, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        public Book_detail()
        {

            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
   }
}
