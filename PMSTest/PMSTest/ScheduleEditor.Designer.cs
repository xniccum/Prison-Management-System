﻿namespace PMSTest
{
    partial class ScheduleEditor
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shiftComboBox = new System.Windows.Forms.ComboBox();
            this.schedulesComboBox = new System.Windows.Forms.ComboBox();
            this.jobSchedulesComboBox = new System.Windows.Forms.ComboBox();
            this.guardSchedulesComboBox = new System.Windows.Forms.ComboBox();
            this.shift_IUpanel = new System.Windows.Forms.Panel();
            this.shift_Dpanel = new System.Windows.Forms.Panel();
            this.schedules_Dpanel = new System.Windows.Forms.Panel();
            this.schedules_IUpanel = new System.Windows.Forms.Panel();
            this.guardSchedules_Dpanel = new System.Windows.Forms.Panel();
            this.guardSchedules_IUpanel = new System.Windows.Forms.Panel();
            this.jobSchedules_Dpanel = new System.Windows.Forms.Panel();
            this.jobSchedules_IUpanel = new System.Windows.Forms.Panel();
            this.shift_delete_label1 = new System.Windows.Forms.Label();
            this.shift_delete_label2 = new System.Windows.Forms.Label();
            this.shift_delete_button1 = new System.Windows.Forms.Button();
            this.shift_Delete_TextBox1 = new System.Windows.Forms.TextBox();
            this.shift_IU_label1 = new System.Windows.Forms.Label();
            this.shift_IU_label2 = new System.Windows.Forms.Label();
            this.shift_IU_label3 = new System.Windows.Forms.Label();
            this.shift_IU_textBox1 = new System.Windows.Forms.TextBox();
            this.shift_IU_textBox2 = new System.Windows.Forms.TextBox();
            this.shift_IU_textBox3 = new System.Windows.Forms.TextBox();
            this.shift_IU_button1 = new System.Windows.Forms.Button();
            this.shift_IUpanel.SuspendLayout();
            this.shift_Dpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shifts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Schedules";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Job Schedules";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Guard Schedules";
            // 
            // shiftComboBox
            // 
            this.shiftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shiftComboBox.FormattingEnabled = true;
            this.shiftComboBox.Location = new System.Drawing.Point(12, 24);
            this.shiftComboBox.Name = "shiftComboBox";
            this.shiftComboBox.Size = new System.Drawing.Size(121, 21);
            this.shiftComboBox.TabIndex = 5;
            this.shiftComboBox.SelectedIndexChanged += new System.EventHandler(this.shiftComboBox_SelectedIndexChanged);
            // 
            // schedulesComboBox
            // 
            this.schedulesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schedulesComboBox.FormattingEnabled = true;
            this.schedulesComboBox.Location = new System.Drawing.Point(146, 24);
            this.schedulesComboBox.Name = "schedulesComboBox";
            this.schedulesComboBox.Size = new System.Drawing.Size(121, 21);
            this.schedulesComboBox.TabIndex = 6;
            // 
            // jobSchedulesComboBox
            // 
            this.jobSchedulesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobSchedulesComboBox.FormattingEnabled = true;
            this.jobSchedulesComboBox.Location = new System.Drawing.Point(281, 24);
            this.jobSchedulesComboBox.Name = "jobSchedulesComboBox";
            this.jobSchedulesComboBox.Size = new System.Drawing.Size(121, 21);
            this.jobSchedulesComboBox.TabIndex = 7;
            // 
            // guardSchedulesComboBox
            // 
            this.guardSchedulesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guardSchedulesComboBox.FormattingEnabled = true;
            this.guardSchedulesComboBox.Location = new System.Drawing.Point(417, 24);
            this.guardSchedulesComboBox.Name = "guardSchedulesComboBox";
            this.guardSchedulesComboBox.Size = new System.Drawing.Size(121, 21);
            this.guardSchedulesComboBox.TabIndex = 8;
            // 
            // shift_IUpanel
            // 
            this.shift_IUpanel.Controls.Add(this.shift_IU_button1);
            this.shift_IUpanel.Controls.Add(this.shift_IU_textBox3);
            this.shift_IUpanel.Controls.Add(this.shift_IU_textBox2);
            this.shift_IUpanel.Controls.Add(this.shift_IU_textBox1);
            this.shift_IUpanel.Controls.Add(this.shift_IU_label3);
            this.shift_IUpanel.Controls.Add(this.shift_IU_label2);
            this.shift_IUpanel.Controls.Add(this.shift_IU_label1);
            this.shift_IUpanel.Location = new System.Drawing.Point(12, 51);
            this.shift_IUpanel.Name = "shift_IUpanel";
            this.shift_IUpanel.Size = new System.Drawing.Size(271, 189);
            this.shift_IUpanel.TabIndex = 0;
            // 
            // shift_Dpanel
            // 
            this.shift_Dpanel.Controls.Add(this.shift_Delete_TextBox1);
            this.shift_Dpanel.Controls.Add(this.shift_delete_button1);
            this.shift_Dpanel.Controls.Add(this.shift_delete_label2);
            this.shift_Dpanel.Controls.Add(this.shift_delete_label1);
            this.shift_Dpanel.Location = new System.Drawing.Point(12, 263);
            this.shift_Dpanel.Name = "shift_Dpanel";
            this.shift_Dpanel.Size = new System.Drawing.Size(270, 214);
            this.shift_Dpanel.TabIndex = 10;
            // 
            // schedules_Dpanel
            // 
            this.schedules_Dpanel.Location = new System.Drawing.Point(308, 263);
            this.schedules_Dpanel.Name = "schedules_Dpanel";
            this.schedules_Dpanel.Size = new System.Drawing.Size(305, 214);
            this.schedules_Dpanel.TabIndex = 12;
            // 
            // schedules_IUpanel
            // 
            this.schedules_IUpanel.Location = new System.Drawing.Point(308, 51);
            this.schedules_IUpanel.Name = "schedules_IUpanel";
            this.schedules_IUpanel.Size = new System.Drawing.Size(306, 189);
            this.schedules_IUpanel.TabIndex = 11;
            // 
            // guardSchedules_Dpanel
            // 
            this.guardSchedules_Dpanel.Location = new System.Drawing.Point(929, 263);
            this.guardSchedules_Dpanel.Name = "guardSchedules_Dpanel";
            this.guardSchedules_Dpanel.Size = new System.Drawing.Size(305, 214);
            this.guardSchedules_Dpanel.TabIndex = 16;
            // 
            // guardSchedules_IUpanel
            // 
            this.guardSchedules_IUpanel.Location = new System.Drawing.Point(929, 51);
            this.guardSchedules_IUpanel.Name = "guardSchedules_IUpanel";
            this.guardSchedules_IUpanel.Size = new System.Drawing.Size(306, 189);
            this.guardSchedules_IUpanel.TabIndex = 15;
            // 
            // jobSchedules_Dpanel
            // 
            this.jobSchedules_Dpanel.Location = new System.Drawing.Point(633, 263);
            this.jobSchedules_Dpanel.Name = "jobSchedules_Dpanel";
            this.jobSchedules_Dpanel.Size = new System.Drawing.Size(270, 214);
            this.jobSchedules_Dpanel.TabIndex = 14;
            // 
            // jobSchedules_IUpanel
            // 
            this.jobSchedules_IUpanel.Location = new System.Drawing.Point(633, 51);
            this.jobSchedules_IUpanel.Name = "jobSchedules_IUpanel";
            this.jobSchedules_IUpanel.Size = new System.Drawing.Size(271, 189);
            this.jobSchedules_IUpanel.TabIndex = 13;
            // 
            // shift_delete_label1
            // 
            this.shift_delete_label1.AutoSize = true;
            this.shift_delete_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shift_delete_label1.Location = new System.Drawing.Point(16, 13);
            this.shift_delete_label1.Name = "shift_delete_label1";
            this.shift_delete_label1.Size = new System.Drawing.Size(123, 25);
            this.shift_delete_label1.TabIndex = 0;
            this.shift_delete_label1.Text = "Delete Shift";
            this.shift_delete_label1.Click += new System.EventHandler(this.label3_Click);
            // 
            // shift_delete_label2
            // 
            this.shift_delete_label2.AutoSize = true;
            this.shift_delete_label2.Location = new System.Drawing.Point(25, 54);
            this.shift_delete_label2.Name = "shift_delete_label2";
            this.shift_delete_label2.Size = new System.Drawing.Size(96, 13);
            this.shift_delete_label2.TabIndex = 1;
            this.shift_delete_label2.Text = "ID of shift to delete";
            // 
            // shift_delete_button1
            // 
            this.shift_delete_button1.Location = new System.Drawing.Point(144, 76);
            this.shift_delete_button1.Name = "shift_delete_button1";
            this.shift_delete_button1.Size = new System.Drawing.Size(100, 23);
            this.shift_delete_button1.TabIndex = 2;
            this.shift_delete_button1.Text = "Submit";
            this.shift_delete_button1.UseVisualStyleBackColor = true;
            // 
            // shift_Delete_TextBox1
            // 
            this.shift_Delete_TextBox1.Location = new System.Drawing.Point(28, 79);
            this.shift_Delete_TextBox1.Name = "shift_Delete_TextBox1";
            this.shift_Delete_TextBox1.Size = new System.Drawing.Size(100, 20);
            this.shift_Delete_TextBox1.TabIndex = 3;
            // 
            // shift_IU_label1
            // 
            this.shift_IU_label1.AutoSize = true;
            this.shift_IU_label1.Location = new System.Drawing.Point(25, 41);
            this.shift_IU_label1.Name = "shift_IU_label1";
            this.shift_IU_label1.Size = new System.Drawing.Size(90, 13);
            this.shift_IU_label1.TabIndex = 0;
            this.shift_IU_label1.Text = "Shift ID to update";
            // 
            // shift_IU_label2
            // 
            this.shift_IU_label2.AutoSize = true;
            this.shift_IU_label2.Location = new System.Drawing.Point(25, 76);
            this.shift_IU_label2.Name = "shift_IU_label2";
            this.shift_IU_label2.Size = new System.Drawing.Size(58, 13);
            this.shift_IU_label2.TabIndex = 1;
            this.shift_IU_label2.Text = "Start Time:";
            // 
            // shift_IU_label3
            // 
            this.shift_IU_label3.AutoSize = true;
            this.shift_IU_label3.Location = new System.Drawing.Point(25, 115);
            this.shift_IU_label3.Name = "shift_IU_label3";
            this.shift_IU_label3.Size = new System.Drawing.Size(58, 13);
            this.shift_IU_label3.TabIndex = 2;
            this.shift_IU_label3.Text = "End Time: ";
            // 
            // shift_IU_textBox1
            // 
            this.shift_IU_textBox1.Location = new System.Drawing.Point(144, 41);
            this.shift_IU_textBox1.Name = "shift_IU_textBox1";
            this.shift_IU_textBox1.Size = new System.Drawing.Size(100, 20);
            this.shift_IU_textBox1.TabIndex = 3;
            // 
            // shift_IU_textBox2
            // 
            this.shift_IU_textBox2.Location = new System.Drawing.Point(144, 76);
            this.shift_IU_textBox2.Name = "shift_IU_textBox2";
            this.shift_IU_textBox2.Size = new System.Drawing.Size(100, 20);
            this.shift_IU_textBox2.TabIndex = 4;
            // 
            // shift_IU_textBox3
            // 
            this.shift_IU_textBox3.Location = new System.Drawing.Point(144, 108);
            this.shift_IU_textBox3.Name = "shift_IU_textBox3";
            this.shift_IU_textBox3.Size = new System.Drawing.Size(100, 20);
            this.shift_IU_textBox3.TabIndex = 5;
            // 
            // shift_IU_button1
            // 
            this.shift_IU_button1.Location = new System.Drawing.Point(144, 150);
            this.shift_IU_button1.Name = "shift_IU_button1";
            this.shift_IU_button1.Size = new System.Drawing.Size(100, 23);
            this.shift_IU_button1.TabIndex = 6;
            this.shift_IU_button1.Text = "Submit";
            this.shift_IU_button1.UseVisualStyleBackColor = true;
            // 
            // ScheduleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 495);
            this.Controls.Add(this.guardSchedules_Dpanel);
            this.Controls.Add(this.guardSchedules_IUpanel);
            this.Controls.Add(this.jobSchedules_Dpanel);
            this.Controls.Add(this.jobSchedules_IUpanel);
            this.Controls.Add(this.schedules_Dpanel);
            this.Controls.Add(this.schedules_IUpanel);
            this.Controls.Add(this.shift_Dpanel);
            this.Controls.Add(this.shift_IUpanel);
            this.Controls.Add(this.guardSchedulesComboBox);
            this.Controls.Add(this.jobSchedulesComboBox);
            this.Controls.Add(this.schedulesComboBox);
            this.Controls.Add(this.shiftComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleEditor";
            this.Text = "ScheduleEditor";
            this.Load += new System.EventHandler(this.ScheduleEditor_Load);
            this.shift_IUpanel.ResumeLayout(false);
            this.shift_IUpanel.PerformLayout();
            this.shift_Dpanel.ResumeLayout(false);
            this.shift_Dpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox shiftComboBox;
        private System.Windows.Forms.ComboBox schedulesComboBox;
        private System.Windows.Forms.ComboBox jobSchedulesComboBox;
        private System.Windows.Forms.ComboBox guardSchedulesComboBox;
        private System.Windows.Forms.Panel shift_IUpanel;
        private System.Windows.Forms.Panel shift_Dpanel;
        private System.Windows.Forms.Panel schedules_Dpanel;
        private System.Windows.Forms.Panel schedules_IUpanel;
        private System.Windows.Forms.Panel guardSchedules_Dpanel;
        private System.Windows.Forms.Panel guardSchedules_IUpanel;
        private System.Windows.Forms.Panel jobSchedules_Dpanel;
        private System.Windows.Forms.Panel jobSchedules_IUpanel;
        private System.Windows.Forms.Label shift_delete_label1;
        private System.Windows.Forms.TextBox shift_Delete_TextBox1;
        private System.Windows.Forms.Button shift_delete_button1;
        private System.Windows.Forms.Label shift_delete_label2;
        private System.Windows.Forms.Button shift_IU_button1;
        private System.Windows.Forms.TextBox shift_IU_textBox3;
        private System.Windows.Forms.TextBox shift_IU_textBox2;
        private System.Windows.Forms.TextBox shift_IU_textBox1;
        private System.Windows.Forms.Label shift_IU_label3;
        private System.Windows.Forms.Label shift_IU_label2;
        private System.Windows.Forms.Label shift_IU_label1;
    }
}