namespace Final_Term_Project
{
    partial class Form_DepartmentInfoView
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
            this.button_Search_Dpt_ID = new System.Windows.Forms.Button();
            this.dataGridView_Info = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.textBox_DptID = new System.Windows.Forms.TextBox();
            this.label_DptId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Search_Dpt_ID
            // 
            this.button_Search_Dpt_ID.Location = new System.Drawing.Point(695, 405);
            this.button_Search_Dpt_ID.Name = "button_Search_Dpt_ID";
            this.button_Search_Dpt_ID.Size = new System.Drawing.Size(82, 33);
            this.button_Search_Dpt_ID.TabIndex = 24;
            this.button_Search_Dpt_ID.Text = "Search";
            this.button_Search_Dpt_ID.UseVisualStyleBackColor = true;
            this.button_Search_Dpt_ID.Click += new System.EventHandler(this.button_Search_Dpt_ID_Click);
            // 
            // dataGridView_Info
            // 
            this.dataGridView_Info.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Info.Location = new System.Drawing.Point(88, 92);
            this.dataGridView_Info.Name = "dataGridView_Info";
            this.dataGridView_Info.RowHeadersWidth = 62;
            this.dataGridView_Info.RowTemplate.Height = 28;
            this.dataGridView_Info.Size = new System.Drawing.Size(630, 215);
            this.dataGridView_Info.TabIndex = 22;
            this.dataGridView_Info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Info_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Department Informations View";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(12, 412);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(85, 32);
            this.button_Back.TabIndex = 35;
            this.button_Back.Text = "<--Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // textBox_DptID
            // 
            this.textBox_DptID.Location = new System.Drawing.Point(412, 384);
            this.textBox_DptID.Name = "textBox_DptID";
            this.textBox_DptID.Size = new System.Drawing.Size(200, 26);
            this.textBox_DptID.TabIndex = 30;
            this.textBox_DptID.TextChanged += new System.EventHandler(this.textBox_DptID_TextChanged);
            // 
            // label_DptId
            // 
            this.label_DptId.AutoSize = true;
            this.label_DptId.Location = new System.Drawing.Point(262, 384);
            this.label_DptId.Name = "label_DptId";
            this.label_DptId.Size = new System.Drawing.Size(116, 20);
            this.label_DptId.TabIndex = 26;
            this.label_DptId.Text = "Department Id ";
            // 
            // Form_DepartmentInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.textBox_DptID);
            this.Controls.Add(this.label_DptId);
            this.Controls.Add(this.button_Search_Dpt_ID);
            this.Controls.Add(this.dataGridView_Info);
            this.Controls.Add(this.label1);
            this.Name = "Form_DepartmentInfoView";
            this.Text = "Form_DepartmentInfoView";
            this.Load += new System.EventHandler(this.Form_DepartmentInfoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Search_Dpt_ID;
        private System.Windows.Forms.DataGridView dataGridView_Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.TextBox textBox_DptID;
        private System.Windows.Forms.Label label_DptId;
    }
}