namespace Final_Term_Project
{
    partial class Office_Informations
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
            this.button_Dpt_Info = new System.Windows.Forms.Button();
            this.button_Doctor_Info = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Office Informations";
            // 
            // button_Dpt_Info
            // 
            this.button_Dpt_Info.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Dpt_Info.Location = new System.Drawing.Point(496, 84);
            this.button_Dpt_Info.Name = "button_Dpt_Info";
            this.button_Dpt_Info.Size = new System.Drawing.Size(256, 90);
            this.button_Dpt_Info.TabIndex = 1;
            this.button_Dpt_Info.Text = "Department Information View";
            this.button_Dpt_Info.UseVisualStyleBackColor = false;
            this.button_Dpt_Info.Click += new System.EventHandler(this.button_Dpt_Info_Click);
            // 
            // button_Doctor_Info
            // 
            this.button_Doctor_Info.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Doctor_Info.Location = new System.Drawing.Point(496, 279);
            this.button_Doctor_Info.Name = "button_Doctor_Info";
            this.button_Doctor_Info.Size = new System.Drawing.Size(246, 95);
            this.button_Doctor_Info.TabIndex = 2;
            this.button_Doctor_Info.Text = "Doctor Information View";
            this.button_Doctor_Info.UseVisualStyleBackColor = false;
            this.button_Doctor_Info.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "<-- Back ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(40, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 90);
            this.button1.TabIndex = 16;
            this.button1.Text = "Insert Department Information";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(40, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 90);
            this.button2.TabIndex = 15;
            this.button2.Text = "Insert Doctors Information";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(685, 411);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(112, 36);
            this.button_Close.TabIndex = 17;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Office_Informations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_Doctor_Info);
            this.Controls.Add(this.button_Dpt_Info);
            this.Controls.Add(this.label1);
            this.Name = "Office_Informations";
            this.Text = "Form_View_Informations";
            this.Load += new System.EventHandler(this.Form_View_Informations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Dpt_Info;
        private System.Windows.Forms.Button button_Doctor_Info;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Close;
    }
}