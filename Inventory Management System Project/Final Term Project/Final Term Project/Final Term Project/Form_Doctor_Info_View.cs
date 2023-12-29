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
    public partial class Form_Doctor_Info_View : Form
    {
        public Form_Doctor_Info_View()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6KJA3SM\\SQLEXPRESS;database =Final Project OOP2;Integrated Security=True");
        private void Display_Data()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DoctorsInfo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            da.Fill(dt);
            dataGridView_Info.DataSource = dt;
            con.Close();
        }
        private void Form_Doctor_Info_View_Load(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Office_Informations vi = new Office_Informations();
            vi.Show();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
           
            
        }

        private void label_Doc_ID_Click(object sender, EventArgs e)
        {

        }

        private void button_Search_Dpt_ID_Click(object sender, EventArgs e)
        {
            int DoctorID = Convert.ToInt32(textBox_DocInfo_ID.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DoctorsInfo where Doctors_ID = '" + DoctorID + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            da.Fill(dt);
            dataGridView_Info.DataSource = dt;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
