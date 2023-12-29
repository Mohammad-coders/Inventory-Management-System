namespace Final_Term_Project
{
    partial class Patient_Informations
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
            this.button_Patient_Info = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Patient_Info
            // 
            this.button_Patient_Info.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Patient_Info.ForeColor = System.Drawing.SystemColors.Info;
            this.button_Patient_Info.Location = new System.Drawing.Point(74, 162);
            this.button_Patient_Info.Name = "button_Patient_Info";
            this.button_Patient_Info.Size = new System.Drawing.Size(275, 90);
            this.button_Patient_Info.TabIndex = 12;
            this.button_Patient_Info.Text = "Insert Patient Information";
            this.button_Patient_Info.UseVisualStyleBackColor = false;
            this.button_Patient_Info.Click += new System.EventHandler(this.button_Patient_Info_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Patient Information ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(480, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 90);
            this.button1.TabIndex = 15;
            this.button1.Text = "Patient Information View";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(685, 410);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(112, 36);
            this.button_Close.TabIndex = 19;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 36);
            this.button4.TabIndex = 18;
            this.button4.Text = "<-- Back ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Patient_Informations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Patient_Info);
            this.Name = "Patient_Informations";
            this.Text = "Form3_HospitalSystem";
            this.Load += new System.EventHandler(this.Form3_HospitalSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Patient_Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button4;
    }
}