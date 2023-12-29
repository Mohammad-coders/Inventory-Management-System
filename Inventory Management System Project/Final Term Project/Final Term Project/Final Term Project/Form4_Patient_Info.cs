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
    public partial class Form4_Patient_Info : Form
    {
        public Form4_Patient_Info()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6KJA3SM\\SQLEXPRESS;database =Final Project OOP2;Integrated Security=True");

        public void GetPatientId()
        {
            string proid;
            string querry = "select Patient_ID from PatientInfo order by Patient_ID Desc";
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                proid = id.ToString("00000");

            }
            else if (Convert.IsDBNull(dr))
            {
                proid = ("00001");
            }
            else
            {
                proid = ("00001");
            }
            con.Close();

            textBox_PT_ID.Text = proid.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int PTID = Convert.ToInt32(textBox_PT_ID.Text);
                String PtName = textBox_PT_Name.Text;
                int Age = Convert.ToInt32(textBox_Pt_Age.Text);
                String sex = checkedListBox_Sex.Text;
                int PhNo = Convert.ToInt32(textBox_PT_PhoneNo.Text);
                String Address = textBox_PT_Address.Text;
                String PatientType = checkedListBox_Ptype.Text;
                String Condition = text_PT_Conditions.Text;
                String RoomNo = checkedListBox_Room.Text;
                int DocID = Convert.ToInt32(textBox_D_ID.Text);
                String date = dateTimePicker1.Text;
                int Pay = Convert.ToInt32(textBox_Payment.Text);




                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-6KJA3SM\\SQLEXPRESS;database =Final Project OOP2;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into PatientInfo values ('" + PTID + "','" + PtName + "','" + Age + "','" + sex + "','" + PhNo + "','" + Address + "','" + PatientType + "','" + Condition + "','" + RoomNo + "','" + DocID + "','" + date + "','" + Pay + "');";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show(" Data Saved!");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Data Format ");
            }

            textBox_PT_ID.Clear();
            textBox_PT_Name.Clear();
            textBox_Pt_Age.Clear();
            textBox_PT_PhoneNo.Clear();
            textBox_PT_Address.Clear();
            text_PT_Conditions.Clear();
            textBox_D_ID.Clear();
            textBox_Payment.Clear();

            this.Hide();
            Patient_Informations hf = new Patient_Informations();
            hf.Show();

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Informations hf = new Patient_Informations();
            hf.Show();
        }

        private void Form4_Patient_Info_Load(object sender, EventArgs e)
        {
            GetPatientId();
        }

        private void textBox_PT_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
