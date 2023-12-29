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
    public partial class Form_Department : Form
    {
        public Form_Department()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Informations hf = new Patient_Informations();
            hf.Show();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6KJA3SM\\SQLEXPRESS;database =Final Project OOP2;Integrated Security=True");
        
        public void GetProductId()
        {
            string proid;
            string querry = "select Department_ID from Department order by Department_ID Desc";
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

            textBox_DptID.Text = proid.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int DepartmentID = Convert.ToInt32(textBox_DptID.Text);
                String DepartmentName = textBox_DptName.Text;
                String Facility = textBoxFc.Text;
                String DepartmentLocation = textBox_DL.Text;

                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into Department values ('" + DepartmentID + "','" + DepartmentName + "','" + Facility + "','" + DepartmentLocation + "');";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show(" Data Saved!");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Data Format ");
            }

            

            //textBox_DptID.Clear();
            textBox_DptName.Clear();
            textBoxFc.Clear();
            textBox_DL.Clear();

            this.Hide();
            Patient_Informations hf = new Patient_Informations();
            hf.Show();
        }

        private void textBox_DptID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form_Department_Load(object sender, EventArgs e)
        {
            GetProductId();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
