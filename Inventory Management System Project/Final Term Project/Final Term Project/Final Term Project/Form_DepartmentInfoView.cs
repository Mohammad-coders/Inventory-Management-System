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
    public partial class Form_DepartmentInfoView : Form
    {
        public Form_DepartmentInfoView()
        {
            InitializeComponent();
        }

        private void label_Patient_ID_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6KJA3SM\\SQLEXPRESS;database =Final Project OOP2;Integrated Security=True");
        private void button_Search_Dpt_ID_Click(object sender, EventArgs e)
        {
            int DepartmentID = Convert.ToInt32(textBox_DptID.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Department where Department_ID = '" + DepartmentID + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            da.Fill(dt);
            dataGridView_Info.DataSource = dt;
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPatient_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void button_Search_DoctorID_Click(object sender, EventArgs e)
        {

        }

        private void textBox_DoctorID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_DoctorID_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_Info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Search_Patient_ID_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Dpt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Dpt_ID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_DepartmentInfoView_Load(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {

        }

        private void button_View_Click(object sender, EventArgs e)
        {
            Display_Data();


        }
        private void Display_Data()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Department";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            da.Fill(dt);
            dataGridView_Info.DataSource = dt;
            con.Close();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Office_Informations vi = new Office_Informations();
            vi.Show();
        }
      

        private void button_Update_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox_DptID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
