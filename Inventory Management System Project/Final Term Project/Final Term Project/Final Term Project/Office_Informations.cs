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
    public partial class Office_Informations : Form
    {
        public Office_Informations()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Informations hf = new Patient_Informations();
            hf.Show();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6KJA3SM\\SQLEXPRESS;database =Final Project OOP2;Integrated Security=True");
        private void button_Search_Dpt_ID_Click(object sender, EventArgs e)
        {

        }

        private void Form_View_Informations_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Doctor_Info_View doiv = new Form_Doctor_Info_View();
            doiv.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Informations hf = new Patient_Informations();
            hf.Show();
        }

        private void button_Dpt_Info_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DepartmentInfoView div = new Form_DepartmentInfoView();
            div.Show();
        }

        private void button_Patient_Info_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Patient_Info_View piv = new Form_Patient_Info_View();
            piv.Show();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
