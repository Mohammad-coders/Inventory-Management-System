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
    public partial class Form_Doctors_Info : Form
    {
        public Form_Doctors_Info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Informations hf = new Patient_Informations();
            hf.Show();
        }

        private void textBox_Doc_ID_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6KJA3SM\\SQLEXPRESS;database =Final Project OOP2;Integrated Security=True");

        public void GetDocId()
        {
            string proid;
            string querry = "select Doctors_ID from DoctorsInfo order by Doctors_ID Desc";
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

            textBox_Doc_ID.Text = proid.ToString();
        }
        private void button_Submit_Click(object sender, EventArgs e)
        {

            try
            {
                int DocID = Convert.ToInt32(textBox_Doc_ID.Text);
                String DocName = textBox_Doc_Name.Text;
                String Quali = textBox_Dct_Quali.Text;
                String DpNAme = checkedListBox_DName.Text;
                int DpID = Convert.ToInt32(checkedListBoxDID.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-6KJA3SM\\SQLEXPRESS;database =Final Project OOP2;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into DoctorsInfo values ('" + DocID + "','" + DocName + "','" + Quali + "','" + DpNAme + "','" + DpID + "');";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show(" Data Saved!");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Data Format ");
            }



            textBox_Doc_Name.Clear();
            textBox_Dct_Quali.Clear();

            this.Hide();
            Patient_Informations hf = new Patient_Informations();
            hf.Show();

        }

        private void Form_Doctors_Info_Load(object sender, EventArgs e)
        {
            GetDocId();
        }

        private void listBox_DptName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
