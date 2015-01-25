namespace Prison_Managment_System_MasterView
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
            this.login_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqlQuery_tb = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_bt
            // 
            this.login_bt.Location = new System.Drawing.Point(15, 93);
            this.login_bt.Name = "login_bt";
            this.login_bt.Size = new System.Drawing.Size(290, 37);
            this.login_bt.TabIndex = 1;
            this.login_bt.Text = "Login";
            this.login_bt.UseVisualStyleBackColor = true;
            this.login_bt.Click += new System.EventHandler(this.login_tb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // login_tb
            // 
            this.login_tb.Location = new System.Drawing.Point(91, 12);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(214, 22);
            this.login_tb.TabIndex = 4;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(91, 52);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(214, 22);
            this.password_tb.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 314);
            this.dataGridView1.TabIndex = 6;
            // 
            // sqlQuery_tb
            // 
            this.sqlQuery_tb.Location = new System.Drawing.Point(317, 12);
            this.sqlQuery_tb.Name = "sqlQuery_tb";
            this.sqlQuery_tb.Size = new System.Drawing.Size(458, 118);
            this.sqlQuery_tb.TabIndex = 7;
            this.sqlQuery_tb.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 474);
            this.Controls.Add(this.sqlQuery_tb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.login_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_bt);
            this.Name = "Form1";
            this.Text = "Master Control";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox sqlQuery_tb;
    }
}

