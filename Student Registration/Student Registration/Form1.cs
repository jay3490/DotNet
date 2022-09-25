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

namespace Student_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load();
        }

        SqlConnection con = new SqlConnection("Data Source = LAPTOP-AN58478H\\SQLEXPRESS; " +
            "Trusted_Connection=True; " +
            "Initial Catalog = Student Registration Db; " +
            "User Id = ; Password = ");
        SqlCommand cmd;
        SqlDataReader read;
        SqlDataAdapter drr;
        string id;
        bool Mode = true;
        string sql;

        public void Load()
        {
            try
            {
                sql = "select * from StudentDetails";
                cmd = new SqlCommand(sql, con);
                con.Open();

                read = cmd.ExecuteReader();
                    
                drr = new SqlDataAdapter(sql, con);
                dataGridView1.Rows.Clear();

                while (read.Read())
                {
                    dataGridView1.Rows.Add(read[0], read[1], read[2], read[3]);
                
                }
                con.Close();
            }
            

            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            
        }

        public void getID(string id)
        {
            sql = "select * from StudentDetails where id = '" + id + "' ";

            cmd = new SqlCommand(sql, con);
            con.Open();
            read = cmd.ExecuteReader();

            while (read.Read())
            { 
                txtName.Text = read[1].ToString();
                txtCourse.Text = read[2].ToString();
                txtFees.Text = read[3].ToString();    
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Course = txtCourse.Text;
            string Fees = txtFees.Text;

            if (Mode == true)
            {
                sql = "insert into StudentDetails(Name, Course, Fees) values(@Name, @Course, @Fees)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Course", Course);
                cmd.Parameters.AddWithValue("@Fees", Fees);
                MessageBox.Show("Record Added!");
                cmd.ExecuteNonQuery();

                txtName.Clear();
                txtCourse.Clear();
                txtFees.Clear();
                txtName.Focus();
            }
            else
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "update StudentDetails set Name = @Name, Course = @Course, Fees = @Fees where id = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Course", Course);
                cmd.Parameters.AddWithValue("@Fees", Fees);
                cmd.Parameters.AddWithValue("@ID", id);
                MessageBox.Show("Record Updated!");
                cmd.ExecuteNonQuery();

                txtName.Clear();
                txtCourse.Clear();
                txtFees.Clear();
                txtName.Focus();
                button1.Text = "Save";
                Mode = true;
            }
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                getID(id);
                button1.Text = "Edit";
            }

            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from StudentDetails where id = @id ";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id ", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtCourse.Clear();
            txtFees.Clear();
            txtName.Focus();
            button1.Text = "Save";
            Mode = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Load();
        }
    }
}
