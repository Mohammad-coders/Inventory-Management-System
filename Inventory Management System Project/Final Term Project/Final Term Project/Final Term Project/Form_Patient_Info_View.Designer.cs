namespace Final_Term_Project
{
    partial class Form_Patient_Info_View
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
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Search_Dpt_ID = new System.Windows.Forms.Button();
            this.dataGridView_Info = new System.Windows.Forms.DataGridView();
            this.textBox_PT_ID = new System.Windows.Forms.TextBox();
            this.label_PT_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 29);
            this.label1.TabIndex = 47;
            this.label1.Text = "Patient Informations View";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(373, 407);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(79, 32);
            this.button_Delete.TabIndex = 46;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(12, 406);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(85, 32);
            this.button_Back.TabIndex = 45;
            this.button_Back.Text = "<--Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Search_Dpt_ID
            // 
            this.button_Search_Dpt_ID.Location = new System.Drawing.Point(705, 406);
            this.button_Search_Dpt_ID.Name = "button_Search_Dpt_ID";
            this.button_Search_Dpt_ID.Size = new System.Drawing.Size(82, 33);
            this.button_Search_Dpt_ID.TabIndex = 43;
            this.button_Search_Dpt_ID.Text = "Search";
            this.button_Search_Dpt_ID.UseVisualStyleBackColor = true;
            this.button_Search_Dpt_ID.Click += new System.EventHandler(this.button_Search_Dpt_ID_Click);
            // 
            // dataGridView_Info
            // 
            this.dataGridView_Info.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Info.Location = new System.Drawing.Point(12, 75);
            this.dataGridView_Info.Name = "dataGridView_Info";
            this.dataGridView_Info.RowHeadersWidth = 62;
            this.dataGridView_Info.RowTemplate.Height = 28;
            this.dataGridView_Info.Size = new System.Drawing.Size(775, 228);
            this.dataGridView_Info.TabIndex = 42;
            this.dataGridView_Info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Info_CellContentClick);
            // 
            // textBox_PT_ID
            // 
            this.textBox_PT_ID.Location = new System.Drawing.Point(358, 330);
            this.textBox_PT_ID.Name = "textBox_PT_ID";
            this.textBox_PT_ID.Size = new System.Drawing.Size(166, 26);
            this.textBox_PT_ID.TabIndex = 78;
            // 
            // label_PT_ID
            // 
            this.label_PT_ID.AutoSize = true;
            this.label_PT_ID.Location = new System.Drawing.Point(306, 333);
            this.label_PT_ID.Name = "label_PT_ID";
            this.label_PT_ID.Size = new System.Drawing.Size(26, 20);
            this.label_PT_ID.TabIndex = 62;
            this.label_PT_ID.Text = "ID";
            this.label_PT_ID.Click += new System.EventHandler(this.label_PT_ID_Click);
            // 
            // Form_Patient_Info_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_PT_ID);
            this.Controls.Add(this.label_PT_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Search_Dpt_ID);
            this.Controls.Add(this.dataGridView_Info);
            this.Name = "Form_Patient_Info_View";
            this.Text = "Form_Patient_Info_View";
            this.Load += new System.EventHandler(this.Form_Patient_Info_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Search_Dpt_ID;
        private System.Windows.Forms.DataGridView dataGridView_Info;
        private System.Windows.Forms.TextBox textBox_PT_ID;
        private System.Windows.Forms.Label label_PT_ID;
    }
}