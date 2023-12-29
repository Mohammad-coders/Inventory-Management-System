namespace Final_Term_Project
{
    partial class Form2_Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_EmpID = new System.Windows.Forms.Label();
            this.label_EmpName = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_EmpId = new System.Windows.Forms.TextBox();
            this.textBox_EmpName = new System.Windows.Forms.TextBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_EmpType = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_EmpID
            // 
            this.label_EmpID.AutoSize = true;
            this.label_EmpID.Location = new System.Drawing.Point(166, 124);
            this.label_EmpID.Name = "label_EmpID";
            this.label_EmpID.Size = new System.Drawing.Size(101, 20);
            this.label_EmpID.TabIndex = 0;
            this.label_EmpID.Text = "Employee Id ";
            // 
            // label_EmpName
            // 
            this.label_EmpName.AutoSize = true;
            this.label_EmpName.Location = new System.Drawing.Point(166, 175);
            this.label_EmpName.Name = "label_EmpName";
            this.label_EmpName.Size = new System.Drawing.Size(129, 20);
            this.label_EmpName.TabIndex = 1;
            this.label_EmpName.Text = "Employee Name ";
            this.label_EmpName.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(166, 225);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(130, 20);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Create Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Welcome To Registration Form\r\n";
            // 
            // textBox_EmpId
            // 
            this.textBox_EmpId.Location = new System.Drawing.Point(357, 118);
            this.textBox_EmpId.Multiline = true;
            this.textBox_EmpId.Name = "textBox_EmpId";
            this.textBox_EmpId.Size = new System.Drawing.Size(158, 26);
            this.textBox_EmpId.TabIndex = 4;
            // 
            // textBox_EmpName
            // 
            this.textBox_EmpName.Location = new System.Drawing.Point(357, 175);
            this.textBox_EmpName.Multiline = true;
            this.textBox_EmpName.Name = "textBox_EmpName";
            this.textBox_EmpName.Size = new System.Drawing.Size(158, 26);
            this.textBox_EmpName.TabIndex = 5;
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(357, 225);
            this.textBox_Pass.Multiline = true;
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(158, 26);
            this.textBox_Pass.TabIndex = 6;
            this.textBox_Pass.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(115, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "( Employee ID is your User Id )";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(46, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(712, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Note: Provide all information, Otherwise your account will be not accepted by Sof" +
    "tware Dedpartment ";
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(377, 316);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(138, 29);
            this.button_Submit.TabIndex = 9;
            this.button_Submit.Text = "Submit ";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(3, 418);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(126, 29);
            this.button_Cancel.TabIndex = 10;
            this.button_Cancel.Text = "<--Back";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(521, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "*Like 0123456789";
            // 
            // listBox_EmpType
            // 
            this.listBox_EmpType.FormattingEnabled = true;
            this.listBox_EmpType.ItemHeight = 20;
            this.listBox_EmpType.Items.AddRange(new object[] {
            "Office Data Entry",
            "Patient Data Entry"});
            this.listBox_EmpType.Location = new System.Drawing.Point(357, 269);
            this.listBox_EmpType.Name = "listBox_EmpType";
            this.listBox_EmpType.Size = new System.Drawing.Size(158, 24);
            this.listBox_EmpType.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Employee Type\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(676, 411);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(112, 36);
            this.button_Close.TabIndex = 19;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Form2_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_EmpType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.textBox_EmpName);
            this.Controls.Add(this.textBox_EmpId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_EmpName);
            this.Controls.Add(this.label_EmpID);
            this.Name = "Form2_Registration";
            this.Text = "Form2_Registration";
            this.Load += new System.EventHandler(this.Form2_Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_EmpID;
        private System.Windows.Forms.Label label_EmpName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_EmpId;
        private System.Windows.Forms.TextBox textBox_EmpName;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_EmpType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Close;
    }
}