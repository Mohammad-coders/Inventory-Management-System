namespace Final_Term_Project
{
    partial class Form1
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
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Registration = new System.Windows.Forms.Button();
            this.textBox_UserId_Box = new System.Windows.Forms.TextBox();
            this.textBox_Password_box = new System.Windows.Forms.TextBox();
            this.label_UserID = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_EmpType = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Login.Location = new System.Drawing.Point(429, 264);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(78, 29);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Registration
            // 
            this.button_Registration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Registration.Location = new System.Drawing.Point(246, 264);
            this.button_Registration.Name = "button_Registration";
            this.button_Registration.Size = new System.Drawing.Size(106, 29);
            this.button_Registration.TabIndex = 1;
            this.button_Registration.Text = "Registration";
            this.button_Registration.UseVisualStyleBackColor = false;
            this.button_Registration.Click += new System.EventHandler(this.button_Registration_Click);
            // 
            // textBox_UserId_Box
            // 
            this.textBox_UserId_Box.Location = new System.Drawing.Point(349, 98);
            this.textBox_UserId_Box.Name = "textBox_UserId_Box";
            this.textBox_UserId_Box.Size = new System.Drawing.Size(158, 26);
            this.textBox_UserId_Box.TabIndex = 2;
            this.textBox_UserId_Box.TextChanged += new System.EventHandler(this.textBox_UserId_Box_TextChanged);
            // 
            // textBox_Password_box
            // 
            this.textBox_Password_box.Location = new System.Drawing.Point(349, 155);
            this.textBox_Password_box.Multiline = true;
            this.textBox_Password_box.Name = "textBox_Password_box";
            this.textBox_Password_box.PasswordChar = '*';
            this.textBox_Password_box.Size = new System.Drawing.Size(158, 25);
            this.textBox_Password_box.TabIndex = 3;
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.Location = new System.Drawing.Point(245, 102);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(64, 20);
            this.label_UserID.TabIndex = 4;
            this.label_UserID.Text = "User ID";
            this.label_UserID.Click += new System.EventHandler(this.label_UserID_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(242, 160);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(78, 20);
            this.label_Password.TabIndex = 5;
            this.label_Password.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(122, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Note: Your User ID and Password will be confirmed  by Software Department .\r\nPlea" +
    "se, Provide your proper information in the registration from.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Employee Type\r\n";
            // 
            // listBox_EmpType
            // 
            this.listBox_EmpType.FormattingEnabled = true;
            this.listBox_EmpType.ItemHeight = 20;
            this.listBox_EmpType.Items.AddRange(new object[] {
            "Office Data Entry",
            "Patient Data Entry"});
            this.listBox_EmpType.Location = new System.Drawing.Point(349, 210);
            this.listBox_EmpType.Name = "listBox_EmpType";
            this.listBox_EmpType.Size = new System.Drawing.Size(158, 24);
            this.listBox_EmpType.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_EmpType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_UserID);
            this.Controls.Add(this.textBox_Password_box);
            this.Controls.Add(this.textBox_UserId_Box);
            this.Controls.Add(this.button_Registration);
            this.Controls.Add(this.button_Login);
            this.Name = "Form1";
            this.Text = "Hospital Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Registration;
        private System.Windows.Forms.TextBox textBox_UserId_Box;
        private System.Windows.Forms.TextBox textBox_Password_box;
        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_EmpType;
    }
}

