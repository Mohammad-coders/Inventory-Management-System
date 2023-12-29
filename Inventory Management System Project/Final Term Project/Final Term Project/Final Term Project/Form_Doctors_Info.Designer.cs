namespace Final_Term_Project
{
    partial class Form_Doctors_Info
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Submit = new System.Windows.Forms.Button();
            this.textBox_Doc_ID = new System.Windows.Forms.TextBox();
            this.textBox_Dct_Quali = new System.Windows.Forms.TextBox();
            this.textBox_Doc_Name = new System.Windows.Forms.TextBox();
            this.label_DptID = new System.Windows.Forms.Label();
            this.label_DptName = new System.Windows.Forms.Label();
            this.label_Dct_Quali = new System.Windows.Forms.Label();
            this.label_Doc_ID = new System.Windows.Forms.Label();
            this.label_Doc_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox_DName = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxDID = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(252, 338);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(95, 30);
            this.button_Cancel.TabIndex = 55;
            this.button_Cancel.Text = "<--Back";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(495, 338);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(109, 30);
            this.button_Submit.TabIndex = 54;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // textBox_Doc_ID
            // 
            this.textBox_Doc_ID.Location = new System.Drawing.Point(433, 85);
            this.textBox_Doc_ID.Name = "textBox_Doc_ID";
            this.textBox_Doc_ID.ReadOnly = true;
            this.textBox_Doc_ID.Size = new System.Drawing.Size(231, 26);
            this.textBox_Doc_ID.TabIndex = 47;
            this.textBox_Doc_ID.TextChanged += new System.EventHandler(this.textBox_Doc_ID_TextChanged);
            // 
            // textBox_Dct_Quali
            // 
            this.textBox_Dct_Quali.Location = new System.Drawing.Point(433, 177);
            this.textBox_Dct_Quali.Name = "textBox_Dct_Quali";
            this.textBox_Dct_Quali.Size = new System.Drawing.Size(231, 26);
            this.textBox_Dct_Quali.TabIndex = 45;
            // 
            // textBox_Doc_Name
            // 
            this.textBox_Doc_Name.Location = new System.Drawing.Point(433, 131);
            this.textBox_Doc_Name.Name = "textBox_Doc_Name";
            this.textBox_Doc_Name.Size = new System.Drawing.Size(231, 26);
            this.textBox_Doc_Name.TabIndex = 41;
            // 
            // label_DptID
            // 
            this.label_DptID.AutoSize = true;
            this.label_DptID.Location = new System.Drawing.Point(248, 287);
            this.label_DptID.Name = "label_DptID";
            this.label_DptID.Size = new System.Drawing.Size(115, 20);
            this.label_DptID.TabIndex = 35;
            this.label_DptID.Text = "Department ID";
            // 
            // label_DptName
            // 
            this.label_DptName.AutoSize = true;
            this.label_DptName.Location = new System.Drawing.Point(248, 240);
            this.label_DptName.Name = "label_DptName";
            this.label_DptName.Size = new System.Drawing.Size(140, 20);
            this.label_DptName.TabIndex = 34;
            this.label_DptName.Text = "Department Name";
            // 
            // label_Dct_Quali
            // 
            this.label_Dct_Quali.AutoSize = true;
            this.label_Dct_Quali.Location = new System.Drawing.Point(248, 180);
            this.label_Dct_Quali.Name = "label_Dct_Quali";
            this.label_Dct_Quali.Size = new System.Drawing.Size(104, 20);
            this.label_Dct_Quali.TabIndex = 32;
            this.label_Dct_Quali.Text = "Qualifications";
            // 
            // label_Doc_ID
            // 
            this.label_Doc_ID.AutoSize = true;
            this.label_Doc_ID.Location = new System.Drawing.Point(248, 85);
            this.label_Doc_ID.Name = "label_Doc_ID";
            this.label_Doc_ID.Size = new System.Drawing.Size(26, 20);
            this.label_Doc_ID.TabIndex = 31;
            this.label_Doc_ID.Text = "ID";
            // 
            // label_Doc_Name
            // 
            this.label_Doc_Name.AutoSize = true;
            this.label_Doc_Name.Location = new System.Drawing.Point(248, 131);
            this.label_Doc_Name.Name = "label_Doc_Name";
            this.label_Doc_Name.Size = new System.Drawing.Size(51, 20);
            this.label_Doc_Name.TabIndex = 29;
            this.label_Doc_Name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Doctors Informations";
            // 
            // checkedListBox_DName
            // 
            this.checkedListBox_DName.FormattingEnabled = true;
            this.checkedListBox_DName.Items.AddRange(new object[] {
            "EMERGENCY (00001)",
            "CARDIOLOGY (00002)",
            "NEUROLOGY (00003)",
            "UROLOGY (00004)",
            "GYNECOLOGY (00005)"});
            this.checkedListBox_DName.Location = new System.Drawing.Point(433, 240);
            this.checkedListBox_DName.Name = "checkedListBox_DName";
            this.checkedListBox_DName.Size = new System.Drawing.Size(231, 27);
            this.checkedListBox_DName.TabIndex = 56;
            // 
            // checkedListBoxDID
            // 
            this.checkedListBoxDID.FormattingEnabled = true;
            this.checkedListBoxDID.Items.AddRange(new object[] {
            "00001",
            "00002",
            "00003",
            "00004",
            "00005"});
            this.checkedListBoxDID.Location = new System.Drawing.Point(433, 287);
            this.checkedListBoxDID.Name = "checkedListBoxDID";
            this.checkedListBoxDID.Size = new System.Drawing.Size(231, 27);
            this.checkedListBoxDID.TabIndex = 57;
            // 
            // Form_Doctors_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBoxDID);
            this.Controls.Add(this.checkedListBox_DName);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_Doc_ID);
            this.Controls.Add(this.textBox_Dct_Quali);
            this.Controls.Add(this.textBox_Doc_Name);
            this.Controls.Add(this.label_DptID);
            this.Controls.Add(this.label_DptName);
            this.Controls.Add(this.label_Dct_Quali);
            this.Controls.Add(this.label_Doc_ID);
            this.Controls.Add(this.label_Doc_Name);
            this.Controls.Add(this.label1);
            this.Name = "Form_Doctors_Info";
            this.Text = "Form_DoctorsInfo";
            this.Load += new System.EventHandler(this.Form_Doctors_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.TextBox textBox_Doc_ID;
        private System.Windows.Forms.TextBox textBox_Dct_Quali;
        private System.Windows.Forms.TextBox textBox_Doc_Name;
        private System.Windows.Forms.Label label_DptID;
        private System.Windows.Forms.Label label_DptName;
        private System.Windows.Forms.Label label_Dct_Quali;
        private System.Windows.Forms.Label label_Doc_ID;
        private System.Windows.Forms.Label label_Doc_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox_DName;
        private System.Windows.Forms.CheckedListBox checkedListBoxDID;
    }
}