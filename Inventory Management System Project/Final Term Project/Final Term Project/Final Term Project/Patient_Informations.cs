using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Term_Project
{
    public partial class Patient_Informations : Form
    {
        public Patient_Informations()
        {
            InitializeComponent();
        }

        private void button_Patient_Info_Click(object sender, EventArgs e)
        {
            Form4_Patient_Info pf = new Form4_Patient_Info();
            pf.Show();
            this.Hide();
        }

        private void button_Doctor_Info_Click(object sender, EventArgs e)
        {
            Form_Doctors_Info di = new Form_Doctors_Info();
            di.Show();
            this.Hide();
        }

        private void button_Dpt_Info_Click(object sender, EventArgs e)
        {
            Form_Department dp = new Form_Department();
            dp.Show();
            this.Hide();

        }

        private void button_Info_View_Click(object sender, EventArgs e)
        {
            Office_Informations vi = new Office_Informations();
            vi.Show();
            this.Hide();
        }

        private void Form3_HospitalSystem_Load(object sender, EventArgs e)
        {

        }
    }
}
