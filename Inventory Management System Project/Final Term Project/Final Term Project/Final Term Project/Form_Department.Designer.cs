namespace Final_Term_Project
{
    partial class Form_Department
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_DptID = new System.Windows.Forms.TextBox();
            this.textBoxFc = new System.Windows.Forms.TextBox();
            this.textBox_DptName = new System.Windows.Forms.TextBox();
            this.textBox_DL = new System.Windows.Forms.TextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department Id ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Facility";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department Informations";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dpartment Location";
            // 
            // textBox_DptID
            // 
            this.textBox_DptID.Location = new System.Drawing.Point(375, 116);
            this.textBox_DptID.Name = "textBox_DptID";
            this.textBox_DptID.ReadOnly = true;
            this.textBox_DptID.Size = new System.Drawing.Size(200, 26);
            this.textBox_DptID.TabIndex = 5;
            this.textBox_DptID.TextChanged += new System.EventHandler(this.textBox_DptID_TextChanged);
            // 
            // textBoxFc
            // 
            this.textBoxFc.Location = new System.Drawing.Point(375, 221);
            this.textBoxFc.Name = "textBoxFc";
            this.textBoxFc.Size = new System.Drawing.Size(200, 26);
            this.textBoxFc.TabIndex = 6;
            // 
            // textBox_DptName
            // 
            this.textBox_DptName.Location = new System.Drawing.Point(375, 171);
            this.textBox_DptName.Name = "textBox_DptName";
            this.textBox_DptName.Size = new System.Drawing.Size(200, 26);
            this.textBox_DptName.TabIndex = 7;
            // 
            // textBox_DL
            // 
            this.textBox_DL.Location = new System.Drawing.Point(375, 273);
            this.textBox_DL.Name = "textBox_DL";
            this.textBox_DL.Size = new System.Drawing.Size(200, 26);
            this.textBox_DL.TabIndex = 8;
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(496, 350);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(79, 32);
            this.button_Submit.TabIndex = 9;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(375, 350);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(85, 32);
            this.button_Cancel.TabIndex = 10;
            this.button_Cancel.Text = "<--Back";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_DL);
            this.Controls.Add(this.textBox_DptName);
            this.Controls.Add(this.textBoxFc);
            this.Controls.Add(this.textBox_DptID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Department";
            this.Text = "Form_Department";
            this.Load += new System.EventHandler(this.Form_Department_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_DptID;
        private System.Windows.Forms.TextBox textBoxFc;
        private System.Windows.Forms.TextBox textBox_DptName;
        private System.Windows.Forms.TextBox textBox_DL;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_Cancel;
    }
}