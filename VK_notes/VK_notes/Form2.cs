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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VK_notes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection sql;
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                sql = new SqlConnection(@"Data Source=LAB109PC02\SQLEXPRESS; Initial Catalog=NotesApp; Integrated Security=True;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (sql.State == ConnectionState.Closed)
                    sql.Open();

                DateTime today = DateTime.Now;

                string Query = "Insert into Notes Values(@title, @content, @timestamp) ";
                SqlCommand cmd = new SqlCommand(Query, sql);
                cmd.CommandType = CommandType.Text;


                cmd.Parameters.AddWithValue("@title", title.Text);
                cmd.Parameters.AddWithValue("@content", content.Text);
                cmd.Parameters.AddWithValue("@timestamp", today);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Your note has been saved!", "Message", MessageBoxButtons.OK);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
