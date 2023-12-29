namespace Final_Term_Project
{
    partial class Form4_Patient_Info
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_PT_Name = new System.Windows.Forms.Label();
            this.label_Pt_Sex = new System.Windows.Forms.Label();
            this.label_PT_ID = new System.Windows.Forms.Label();
            this.label_PT_PhoneNo = new System.Windows.Forms.Label();
            this.label_Pt_Age = new System.Windows.Forms.Label();
            this.label_PT_Address = new System.Windows.Forms.Label();
            this.label_D_ID = new System.Windows.Forms.Label();
            this.label_Payment = new System.Windows.Forms.Label();
            this.label_RoomNo = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_PT_Conditions = new System.Windows.Forms.Label();
            this.label_Patient_Type = new System.Windows.Forms.Label();
            this.textBox_PT_Name = new System.Windows.Forms.TextBox();
            this.text_PT_Conditions = new System.Windows.Forms.TextBox();
            this.textBox_D_ID = new System.Windows.Forms.TextBox();
            this.textBox_Payment = new System.Windows.Forms.TextBox();
            this.textBox_PT_PhoneNo = new System.Windows.Forms.TextBox();
            this.textBox_PT_Address = new System.Windows.Forms.TextBox();
            this.textBox_PT_ID = new System.Windows.Forms.TextBox();
            this.textBox_Pt_Age = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1_Submit = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.checkedListBox_Sex = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_Room = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_Ptype = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Informations";
            // 
            // label_PT_Name
            // 
            this.label_PT_Name.AutoSize = true;
            this.label_PT_Name.Location = new System.Drawing.Point(53, 118);
            this.label_PT_Name.Name = "label_PT_Name";
            this.label_PT_Name.Size = new System.Drawing.Size(51, 20);
            this.label_PT_Name.TabIndex = 1;
            this.label_PT_Name.Text = "Name";
            // 
            // label_Pt_Sex
            // 
            this.label_Pt_Sex.AutoSize = true;
            this.label_Pt_Sex.Location = new System.Drawing.Point(424, 117);
            this.label_Pt_Sex.Name = "label_Pt_Sex";
            this.label_Pt_Sex.Size = new System.Drawing.Size(36, 20);
            this.label_Pt_Sex.TabIndex = 2;
            this.label_Pt_Sex.Text = "Sex";
            // 
            // label_PT_ID
            // 
            this.label_PT_ID.AutoSize = true;
            this.label_PT_ID.Location = new System.Drawing.Point(53, 68);
            this.label_PT_ID.Name = "label_PT_ID";
            this.label_PT_ID.Size = new System.Drawing.Size(26, 20);
            this.label_PT_ID.TabIndex = 3;
            this.label_PT_ID.Text = "ID";
            // 
            // label_PT_PhoneNo
            // 
            this.label_PT_PhoneNo.AutoSize = true;
            this.label_PT_PhoneNo.Location = new System.Drawing.Point(53, 163);
            this.label_PT_PhoneNo.Name = "label_PT_PhoneNo";
            this.label_PT_PhoneNo.Size = new System.Drawing.Size(79, 20);
            this.label_PT_PhoneNo.TabIndex = 4;
            this.label_PT_PhoneNo.Text = "Phone No";
            // 
            // label_Pt_Age
            // 
            this.label_Pt_Age.AutoSize = true;
            this.label_Pt_Age.Location = new System.Drawing.Point(422, 163);
            this.label_Pt_Age.Name = "label_Pt_Age";
            this.label_Pt_Age.Size = new System.Drawing.Size(38, 20);
            this.label_Pt_Age.TabIndex = 5;
            this.label_Pt_Age.Text = "Age";
            // 
            // label_PT_Address
            // 
            this.label_PT_Address.AutoSize = true;
            this.label_PT_Address.Location = new System.Drawing.Point(53, 211);
            this.label_PT_Address.Name = "label_PT_Address";
            this.label_PT_Address.Size = new System.Drawing.Size(68, 20);
            this.label_PT_Address.TabIndex = 6;
            this.label_PT_Address.Text = "Address";
            // 
            // label_D_ID
            // 
            this.label_D_ID.AutoSize = true;
            this.label_D_ID.Location = new System.Drawing.Point(54, 311);
            this.label_D_ID.Name = "label_D_ID";
            this.label_D_ID.Size = new System.Drawing.Size(78, 20);
            this.label_D_ID.TabIndex = 7;
            this.label_D_ID.Text = "Doctor ID";
            this.label_D_ID.Click += new System.EventHandler(this.label8_Click);
            // 
            // label_Payment
            // 
            this.label_Payment.AutoSize = true;
            this.label_Payment.Location = new System.Drawing.Point(424, 311);
            this.label_Payment.Name = "label_Payment";
            this.label_Payment.Size = new System.Drawing.Size(71, 20);
            this.label_Payment.TabIndex = 8;
            this.label_Payment.Text = "Payment";
            // 
            // label_RoomNo
            // 
            this.label_RoomNo.AutoSize = true;
            this.label_RoomNo.Location = new System.Drawing.Point(422, 211);
            this.label_RoomNo.Name = "label_RoomNo";
            this.label_RoomNo.Size = new System.Drawing.Size(141, 20);
            this.label_RoomNo.TabIndex = 9;
            this.label_RoomNo.Text = "Room No(If Admit)";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(424, 261);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(44, 20);
            this.label_Date.TabIndex = 10;
            this.label_Date.Text = "Date";
            // 
            // label_PT_Conditions
            // 
            this.label_PT_Conditions.AutoSize = true;
            this.label_PT_Conditions.Location = new System.Drawing.Point(53, 263);
            this.label_PT_Conditions.Name = "label_PT_Conditions";
            this.label_PT_Conditions.Size = new System.Drawing.Size(141, 20);
            this.label_PT_Conditions.TabIndex = 11;
            this.label_PT_Conditions.Text = "Condition(If Admit)";
            this.label_PT_Conditions.Click += new System.EventHandler(this.label12_Click);
            // 
            // label_Patient_Type
            // 
            this.label_Patient_Type.AutoSize = true;
            this.label_Patient_Type.Location = new System.Drawing.Point(424, 68);
            this.label_Patient_Type.Name = "label_Patient_Type";
            this.label_Patient_Type.Size = new System.Drawing.Size(97, 20);
            this.label_Patient_Type.TabIndex = 12;
            this.label_Patient_Type.Text = "Patient Type";
            // 
            // textBox_PT_Name
            // 
            this.textBox_PT_Name.Location = new System.Drawing.Point(200, 115);
            this.textBox_PT_Name.Name = "textBox_PT_Name";
            this.textBox_PT_Name.Size = new System.Drawing.Size(166, 26);
            this.textBox_PT_Name.TabIndex = 13;
            // 
            // text_PT_Conditions
            // 
            this.text_PT_Conditions.Location = new System.Drawing.Point(200, 258);
            this.text_PT_Conditions.Name = "text_PT_Conditions";
            this.text_PT_Conditions.Size = new System.Drawing.Size(166, 26);
            this.text_PT_Conditions.TabIndex = 14;
            // 
            // textBox_D_ID
            // 
            this.textBox_D_ID.Location = new System.Drawing.Point(200, 308);
            this.textBox_D_ID.Name = "textBox_D_ID";
            this.textBox_D_ID.Size = new System.Drawing.Size(166, 26);
            this.textBox_D_ID.TabIndex = 15;
            // 
            // textBox_Payment
            // 
            this.textBox_Payment.Location = new System.Drawing.Point(569, 308);
            this.textBox_Payment.Name = "textBox_Payment";
            this.textBox_Payment.Size = new System.Drawing.Size(187, 26);
            this.textBox_Payment.TabIndex = 16;
            // 
            // textBox_PT_PhoneNo
            // 
            this.textBox_PT_PhoneNo.Location = new System.Drawing.Point(200, 160);
            this.textBox_PT_PhoneNo.Name = "textBox_PT_PhoneNo";
            this.textBox_PT_PhoneNo.Size = new System.Drawing.Size(166, 26);
            this.textBox_PT_PhoneNo.TabIndex = 17;
            // 
            // textBox_PT_Address
            // 
            this.textBox_PT_Address.Location = new System.Drawing.Point(200, 211);
            this.textBox_PT_Address.Name = "textBox_PT_Address";
            this.textBox_PT_Address.Size = new System.Drawing.Size(166, 26);
            this.textBox_PT_Address.TabIndex = 18;
            // 
            // textBox_PT_ID
            // 
            this.textBox_PT_ID.Location = new System.Drawing.Point(200, 65);
            this.textBox_PT_ID.Name = "textBox_PT_ID";
            this.textBox_PT_ID.ReadOnly = true;
            this.textBox_PT_ID.Size = new System.Drawing.Size(166, 26);
            this.textBox_PT_ID.TabIndex = 19;
            this.textBox_PT_ID.TextChanged += new System.EventHandler(this.textBox_PT_ID_TextChanged);
            // 
            // textBox_Pt_Age
            // 
            this.textBox_Pt_Age.Location = new System.Drawing.Point(569, 160);
            this.textBox_Pt_Age.Name = "textBox_Pt_Age";
            this.textBox_Pt_Age.Size = new System.Drawing.Size(187, 26);
            this.textBox_Pt_Age.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(569, 258);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 26);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // button1_Submit
            // 
            this.button1_Submit.Location = new System.Drawing.Point(603, 383);
            this.button1_Submit.Name = "button1_Submit";
            this.button1_Submit.Size = new System.Drawing.Size(109, 30);
            this.button1_Submit.TabIndex = 26;
            this.button1_Submit.Text = "Submit";
            this.button1_Submit.UseVisualStyleBackColor = true;
            this.button1_Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(232, 383);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(95, 30);
            this.button_Cancel.TabIndex = 27;
            this.button_Cancel.Text = "<--Back";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // checkedListBox_Sex
            // 
            this.checkedListBox_Sex.FormattingEnabled = true;
            this.checkedListBox_Sex.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Others"});
            this.checkedListBox_Sex.Location = new System.Drawing.Point(569, 118);
            this.checkedListBox_Sex.Name = "checkedListBox_Sex";
            this.checkedListBox_Sex.Size = new System.Drawing.Size(187, 27);
            this.checkedListBox_Sex.TabIndex = 57;
            // 
            // checkedListBox_Room
            // 
            this.checkedListBox_Room.FormattingEnabled = true;
            this.checkedListBox_Room.Items.AddRange(new object[] {
            "CCU 01",
            "CCU 02",
            "CCU 03",
            "CCU 04",
            "CCU 05",
            "ICU 01",
            "ICU 02",
            "ICU 03",
            "GW 1(Cardiology)",
            "GW 2(Cardiology)",
            "GW 3(Neurology)",
            "Gw 4(Neurology)",
            "GW 5(Urology)",
            "GW 6(Urology)",
            "GW 7(Gynecology)",
            "GW 8(Gynecology)"});
            this.checkedListBox_Room.Location = new System.Drawing.Point(569, 211);
            this.checkedListBox_Room.Name = "checkedListBox_Room";
            this.checkedListBox_Room.Size = new System.Drawing.Size(187, 27);
            this.checkedListBox_Room.TabIndex = 58;
            this.checkedListBox_Room.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkedListBox_Ptype
            // 
            this.checkedListBox_Ptype.FormattingEnabled = true;
            this.checkedListBox_Ptype.Items.AddRange(new object[] {
            "Regular",
            "Admit"});
            this.checkedListBox_Ptype.Location = new System.Drawing.Point(569, 65);
            this.checkedListBox_Ptype.Name = "checkedListBox_Ptype";
            this.checkedListBox_Ptype.Size = new System.Drawing.Size(187, 27);
            this.checkedListBox_Ptype.TabIndex = 59;
            // 
            // Form4_Patient_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox_Ptype);
            this.Controls.Add(this.checkedListBox_Room);
            this.Controls.Add(this.checkedListBox_Sex);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button1_Submit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_Pt_Age);
            this.Controls.Add(this.textBox_PT_ID);
            this.Controls.Add(this.textBox_PT_Address);
            this.Controls.Add(this.textBox_PT_PhoneNo);
            this.Controls.Add(this.textBox_Payment);
            this.Controls.Add(this.textBox_D_ID);
            this.Controls.Add(this.text_PT_Conditions);
            this.Controls.Add(this.textBox_PT_Name);
            this.Controls.Add(this.label_Patient_Type);
            this.Controls.Add(this.label_PT_Conditions);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_RoomNo);
            this.Controls.Add(this.label_Payment);
            this.Controls.Add(this.label_D_ID);
            this.Controls.Add(this.label_PT_Address);
            this.Controls.Add(this.label_Pt_Age);
            this.Controls.Add(this.label_PT_PhoneNo);
            this.Controls.Add(this.label_PT_ID);
            this.Controls.Add(this.label_Pt_Sex);
            this.Controls.Add(this.label_PT_Name);
            this.Controls.Add(this.label1);
            this.Name = "Form4_Patient_Info";
            this.Text = "Form4_Patient_Info";
            this.Load += new System.EventHandler(this.Form4_Patient_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_PT_Name;
        private System.Windows.Forms.Label label_Pt_Sex;
        private System.Windows.Forms.Label label_PT_ID;
        private System.Windows.Forms.Label label_PT_PhoneNo;
        private System.Windows.Forms.Label label_Pt_Age;
        private System.Windows.Forms.Label label_PT_Address;
        private System.Windows.Forms.Label label_D_ID;
        private System.Windows.Forms.Label label_Payment;
        private System.Windows.Forms.Label label_RoomNo;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_PT_Conditions;
        private System.Windows.Forms.Label label_Patient_Type;
        private System.Windows.Forms.TextBox textBox_PT_Name;
        private System.Windows.Forms.TextBox text_PT_Conditions;
        private System.Windows.Forms.TextBox textBox_D_ID;
        private System.Windows.Forms.TextBox textBox_Payment;
        private System.Windows.Forms.TextBox textBox_PT_PhoneNo;
        private System.Windows.Forms.TextBox textBox_PT_Address;
        private System.Windows.Forms.TextBox textBox_PT_ID;
        private System.Windows.Forms.TextBox textBox_Pt_Age;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1_Submit;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.CheckedListBox checkedListBox_Sex;
        private System.Windows.Forms.CheckedListBox checkedListBox_Room;
        private System.Windows.Forms.CheckedListBox checkedListBox_Ptype;
    }
}