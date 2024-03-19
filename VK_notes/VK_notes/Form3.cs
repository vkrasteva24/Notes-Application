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

namespace VK_notes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection sql;
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                sql = new SqlConnection(@"Data Source=LAB109PC02\SQLEXPRESS; Initial Catalog=NotesApp; Integrated Security=True;");
                sql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string fetchTitle = "SELECT title From Notes WHERE 1=1";
            SqlCommand cmd = new SqlCommand(fetchTitle, sql);
            cmd.CommandType = CommandType.Text;

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                titleB.DataSource = ds.Tables[0];
                titleB.DisplayMember = "title";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void titleB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fetchNote = "SELECT content From Notes WHERE title=@title";
            string fetchTime = "SELECT timestamp From Notes WHERE title=@title";

            SqlCommand cmd2 = new SqlCommand(fetchNote, sql);
            SqlCommand cmd3 = new SqlCommand(fetchTime, sql);

            cmd2.CommandType = CommandType.Text;
            cmd3.CommandType = CommandType.Text;

            cmd2.Parameters.AddWithValue("@title", titleB.Text);
            cmd3.Parameters.AddWithValue("@title", titleB.Text);


            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                if (reader.Read())
                {
                    content.Text = reader["content"].ToString();
                }
            }
            using (SqlDataReader reader2 = cmd3.ExecuteReader())
            {
                if (reader2.Read())
                {
                    timestamp.Text = "Time created: " + reader2["timestamp"].ToString();
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string deleteNote = "Delete From Notes WHERE title=@title";
            SqlCommand cmd = new SqlCommand(deleteNote, sql);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@title", titleB.Text);
            cmd.ExecuteNonQuery();

            DialogResult result = MessageBox.Show("This note will be lost forever! Are you sure you want to delete this note?", "Warning!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your note has been deleted!", "Message", MessageBoxButtons.OK);
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Failed to delete note!", "Message", MessageBoxButtons.OK);
            }
        }
    }
}
