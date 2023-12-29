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

namespace Final_Term_Project
{
    public partial class Form2_Registration : Form
    {
        public Form2_Registration()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
        

        private void button_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                int EmployeeID = Convert.ToInt32(textBox_EmpId.Text);
                String EmployeeName = textBox_EmpName.Text;
                String Password = textBox_Pass.Text;
                string Emp_Type = listBox_EmpType.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-6KJA3SM\\SQLEXPRESS;database =Final Project OOP2;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into Registration values ('" + EmployeeID + "','" + EmployeeName + "','" + Password + "','" + Emp_Type + "');";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show(" Data Saved!");
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Data Format ");
            }

           

            textBox_EmpId.Clear();
            textBox_EmpName.Clear();
            textBox_Pass.Clear();

            //this.Hide();
            //Form1 f = new Form1();
            //f.Show();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Registration_Load(object sender, EventArgs e)
        {

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
