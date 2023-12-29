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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String SqlStr = "";

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6KJA3SM\\SQLEXPRESS;database =Final Project OOP2;Integrated Security=True");
        private void button_Login_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlStr = " select * from Registration where UserID = '" + textBox_UserId_Box.Text + "' and Password = '" + textBox_Password_box.Text + "' and Employee_Type = '" + listBox_EmpType.Text + "'";
            SqlCommand cmd = new SqlCommand(SqlStr, con);

            SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                { 
                    Patient_Informations hs = new Patient_Informations();
                    hs.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User ID or Password");
                    textBox_UserId_Box.Clear();
                    textBox_Password_box.Clear();

                }
            con.Close();
        }

        private void label_UserID_Click(object sender, EventArgs e)
        {

        }
        
         
        private void button_Registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_Registration rg = new Form2_Registration();
            rg.Show();


 

        }

        private void textBox_UserId_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
