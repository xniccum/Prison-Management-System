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
            this.Schedules_Dsubmitbutton = new System.Windows.Forms.Button();
            this.Schedules_ScheduleID_Dinput = new System.Windows.Forms.TextBox();
            this.Schedules_ScheduleID_Dinputlabel = new System.Windows.Forms.Label();
            this.Schedules_Dlabel = new System.Windows.Forms.Label();
            this.schedules_IUpanel = new System.Windows.Forms.Panel();
            this.Schedule_IUsubmitbutton = new System.Windows.Forms.Button();
            this.scheduleupdate_label = new System.Windows.Forms.Label();
            this.scheduleadd_label = new System.Windows.Forms.Label();
            this.Tuesshift_label = new System.Windows.Forms.Label();
            this.wedshift_label = new System.Windows.Forms.Label();
            this.thrusshift_label = new System.Windows.Forms.Label();
            this.Frishift_label = new System.Windows.Forms.Label();
            this.Sunshift_label = new System.Windows.Forms.Label();
            this.Satshift_label = new System.Windows.Forms.Label();
            this.Monshift_label = new System.Windows.Forms.Label();
            this.ScheduleID_label = new System.Windows.Forms.Label();
            this.Satshfit_input = new System.Windows.Forms.TextBox();
            this.Frishift_input = new System.Windows.Forms.TextBox();
            this.Thursshift_input = new System.Windows.Forms.TextBox();
            this.Wedshift_input = new System.Windows.Forms.TextBox();
            this.Tuesshift_input = new System.Windows.Forms.TextBox();
            this.Monshift_input = new System.Windows.Forms.TextBox();
            this.Sunshift_input = new System.Windows.Forms.TextBox();
            this.ScheduleID_input = new System.Windows.Forms.TextBox();
            this.guardSchedules_Dpanel = new System.Windows.Forms.Panel();
            this.guardSchedules_IUpanel = new System.Windows.Forms.Panel();
            this.jobSchedules_Dpanel = new System.Windows.Forms.Panel();
            this.jobSchedule_Dsubmitbutton = new System.Windows.Forms.Button();
            this.jobSchedule_scheduleID_Dinput = new System.Windows.Forms.TextBox();
            this.jobSchedule_ScheduleID_Dlabel = new System.Windows.Forms.Label();
            this.jobSchedule_dlabel = new System.Windows.Forms.Label();
            this.jobSchedules_IUpanel = new System.Windows.Forms.Panel();
            this.jobSchedule_submitbutton = new System.Windows.Forms.Button();
            this.jobSchedules_ScheduleID_Iinput = new System.Windows.Forms.TextBox();
            this.jobSchedules_scheduleID_label = new System.Windows.Forms.Label();
            this.Jobschedules_Ilabel = new System.Windows.Forms.Label();
            this.guardSchedule_Usubmitbutton = new System.Windows.Forms.Button();
            this.guardSchedule_scheduleID_input = new System.Windows.Forms.TextBox();
            this.guardSchedule_scheduleID_label = new System.Windows.Forms.Label();
            this.guardSchedule_Ulabel = new System.Windows.Forms.Label();
            this.schedules_Dpanel.SuspendLayout();
            this.schedules_IUpanel.SuspendLayout();
            this.guardSchedules_IUpanel.SuspendLayout();
            this.jobSchedules_Dpanel.SuspendLayout();
            this.jobSchedules_IUpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shifts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Schedules";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Job Schedules";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Guard Schedules";
            // 
            // shiftComboBox
            // 
            this.shiftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shiftComboBox.FormattingEnabled = true;
            this.shiftComboBox.Location = new System.Drawing.Point(18, 37);
            this.shiftComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shiftComboBox.Name = "shiftComboBox";
            this.shiftComboBox.Size = new System.Drawing.Size(180, 28);
            this.shiftComboBox.TabIndex = 5;
            this.shiftComboBox.SelectedIndexChanged += new System.EventHandler(this.shiftComboBox_SelectedIndexChanged);
            // 
            // schedulesComboBox
            // 
            this.schedulesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schedulesComboBox.FormattingEnabled = true;
            this.schedulesComboBox.Location = new System.Drawing.Point(219, 37);
            this.schedulesComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.schedulesComboBox.Name = "schedulesComboBox";
            this.schedulesComboBox.Size = new System.Drawing.Size(180, 28);
            this.schedulesComboBox.TabIndex = 6;
            this.schedulesComboBox.SelectedIndexChanged += new System.EventHandler(this.schedulesComboBox_SelectedIndexChanged);
            // 
            // jobSchedulesComboBox
            // 
            this.jobSchedulesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobSchedulesComboBox.FormattingEnabled = true;
            this.jobSchedulesComboBox.Location = new System.Drawing.Point(422, 37);
            this.jobSchedulesComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobSchedulesComboBox.Name = "jobSchedulesComboBox";
            this.jobSchedulesComboBox.Size = new System.Drawing.Size(180, 28);
            this.jobSchedulesComboBox.TabIndex = 7;
            // 
            // guardSchedulesComboBox
            // 
            this.guardSchedulesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guardSchedulesComboBox.FormattingEnabled = true;
            this.guardSchedulesComboBox.Location = new System.Drawing.Point(626, 37);
            this.guardSchedulesComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guardSchedulesComboBox.Name = "guardSchedulesComboBox";
            this.guardSchedulesComboBox.Size = new System.Drawing.Size(180, 28);
            this.guardSchedulesComboBox.TabIndex = 8;
            // 
            // shift_IUpanel
            // 
            this.shift_IUpanel.Location = new System.Drawing.Point(18, 78);
            this.shift_IUpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shift_IUpanel.Name = "shift_IUpanel";
            this.shift_IUpanel.Size = new System.Drawing.Size(406, 291);
            this.shift_IUpanel.TabIndex = 0;
            // 
            // shift_Dpanel
            // 
            this.shift_Dpanel.Location = new System.Drawing.Point(18, 405);
            this.shift_Dpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shift_Dpanel.Name = "shift_Dpanel";
            this.shift_Dpanel.Size = new System.Drawing.Size(405, 329);
            this.shift_Dpanel.TabIndex = 10;
            // 
            // schedules_Dpanel
            // 
            this.schedules_Dpanel.Controls.Add(this.Schedules_Dsubmitbutton);
            this.schedules_Dpanel.Controls.Add(this.Schedules_ScheduleID_Dinput);
            this.schedules_Dpanel.Controls.Add(this.Schedules_ScheduleID_Dinputlabel);
            this.schedules_Dpanel.Controls.Add(this.Schedules_Dlabel);
            this.schedules_Dpanel.Location = new System.Drawing.Point(462, 405);
            this.schedules_Dpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.schedules_Dpanel.Name = "schedules_Dpanel";
            this.schedules_Dpanel.Size = new System.Drawing.Size(458, 329);
            this.schedules_Dpanel.TabIndex = 12;
            // 
            // Schedules_Dsubmitbutton
            // 
            this.Schedules_Dsubmitbutton.Location = new System.Drawing.Point(177, 116);
            this.Schedules_Dsubmitbutton.Name = "Schedules_Dsubmitbutton";
            this.Schedules_Dsubmitbutton.Size = new System.Drawing.Size(85, 42);
            this.Schedules_Dsubmitbutton.TabIndex = 19;
            this.Schedules_Dsubmitbutton.Text = "Submit";
            this.Schedules_Dsubmitbutton.UseVisualStyleBackColor = true;
            // 
            // Schedules_ScheduleID_Dinput
            // 
            this.Schedules_ScheduleID_Dinput.Location = new System.Drawing.Point(30, 116);
            this.Schedules_ScheduleID_Dinput.Name = "Schedules_ScheduleID_Dinput";
            this.Schedules_ScheduleID_Dinput.Size = new System.Drawing.Size(100, 26);
            this.Schedules_ScheduleID_Dinput.TabIndex = 2;
            // 
            // Schedules_ScheduleID_Dinputlabel
            // 
            this.Schedules_ScheduleID_Dinputlabel.AutoSize = true;
            this.Schedules_ScheduleID_Dinputlabel.Location = new System.Drawing.Point(26, 72);
            this.Schedules_ScheduleID_Dinputlabel.Name = "Schedules_ScheduleID_Dinputlabel";
            this.Schedules_ScheduleID_Dinputlabel.Size = new System.Drawing.Size(93, 20);
            this.Schedules_ScheduleID_Dinputlabel.TabIndex = 1;
            this.Schedules_ScheduleID_Dinputlabel.Text = "ScheduleID";
            // 
            // Schedules_Dlabel
            // 
            this.Schedules_Dlabel.AutoSize = true;
            this.Schedules_Dlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schedules_Dlabel.Location = new System.Drawing.Point(21, 20);
            this.Schedules_Dlabel.Name = "Schedules_Dlabel";
            this.Schedules_Dlabel.Size = new System.Drawing.Size(192, 29);
            this.Schedules_Dlabel.TabIndex = 0;
            this.Schedules_Dlabel.Text = "Delete Schedule";
            // 
            // schedules_IUpanel
            // 
            this.schedules_IUpanel.Controls.Add(this.Schedule_IUsubmitbutton);
            this.schedules_IUpanel.Controls.Add(this.scheduleupdate_label);
            this.schedules_IUpanel.Controls.Add(this.scheduleadd_label);
            this.schedules_IUpanel.Controls.Add(this.Tuesshift_label);
            this.schedules_IUpanel.Controls.Add(this.wedshift_label);
            this.schedules_IUpanel.Controls.Add(this.thrusshift_label);
            this.schedules_IUpanel.Controls.Add(this.Frishift_label);
            this.schedules_IUpanel.Controls.Add(this.Sunshift_label);
            this.schedules_IUpanel.Controls.Add(this.Satshift_label);
            this.schedules_IUpanel.Controls.Add(this.Monshift_label);
            this.schedules_IUpanel.Controls.Add(this.ScheduleID_label);
            this.schedules_IUpanel.Controls.Add(this.Satshfit_input);
            this.schedules_IUpanel.Controls.Add(this.Frishift_input);
            this.schedules_IUpanel.Controls.Add(this.Thursshift_input);
            this.schedules_IUpanel.Controls.Add(this.Wedshift_input);
            this.schedules_IUpanel.Controls.Add(this.Tuesshift_input);
            this.schedules_IUpanel.Controls.Add(this.Monshift_input);
            this.schedules_IUpanel.Controls.Add(this.Sunshift_input);
            this.schedules_IUpanel.Controls.Add(this.ScheduleID_input);
            this.schedules_IUpanel.Location = new System.Drawing.Point(462, 78);
            this.schedules_IUpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.schedules_IUpanel.Name = "schedules_IUpanel";
            this.schedules_IUpanel.Size = new System.Drawing.Size(459, 291);
            this.schedules_IUpanel.TabIndex = 11;
            // 
            // Schedule_IUsubmitbutton
            // 
            this.Schedule_IUsubmitbutton.Location = new System.Drawing.Point(338, 235);
            this.Schedule_IUsubmitbutton.Name = "Schedule_IUsubmitbutton";
            this.Schedule_IUsubmitbutton.Size = new System.Drawing.Size(85, 42);
            this.Schedule_IUsubmitbutton.TabIndex = 18;
            this.Schedule_IUsubmitbutton.Text = "Submit";
            this.Schedule_IUsubmitbutton.UseVisualStyleBackColor = true;
            // 
            // scheduleupdate_label
            // 
            this.scheduleupdate_label.AutoSize = true;
            this.scheduleupdate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleupdate_label.Location = new System.Drawing.Point(205, 12);
            this.scheduleupdate_label.Name = "scheduleupdate_label";
            this.scheduleupdate_label.Size = new System.Drawing.Size(218, 29);
            this.scheduleupdate_label.TabIndex = 17;
            this.scheduleupdate_label.Text = "Update a Schedule";
            // 
            // scheduleadd_label
            // 
            this.scheduleadd_label.AutoSize = true;
            this.scheduleadd_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleadd_label.Location = new System.Drawing.Point(16, 12);
            this.scheduleadd_label.Name = "scheduleadd_label";
            this.scheduleadd_label.Size = new System.Drawing.Size(183, 29);
            this.scheduleadd_label.TabIndex = 16;
            this.scheduleadd_label.Text = "Add a Schedule";
            // 
            // Tuesshift_label
            // 
            this.Tuesshift_label.AutoSize = true;
            this.Tuesshift_label.Location = new System.Drawing.Point(45, 212);
            this.Tuesshift_label.Name = "Tuesshift_label";
            this.Tuesshift_label.Size = new System.Drawing.Size(106, 20);
            this.Tuesshift_label.TabIndex = 15;
            this.Tuesshift_label.Text = "Tuesday Shift";
            // 
            // wedshift_label
            // 
            this.wedshift_label.AutoSize = true;
            this.wedshift_label.Location = new System.Drawing.Point(205, 46);
            this.wedshift_label.Name = "wedshift_label";
            this.wedshift_label.Size = new System.Drawing.Size(130, 20);
            this.wedshift_label.TabIndex = 14;
            this.wedshift_label.Text = "Wednesday Shift";
            // 
            // thrusshift_label
            // 
            this.thrusshift_label.AutoSize = true;
            this.thrusshift_label.Location = new System.Drawing.Point(204, 104);
            this.thrusshift_label.Name = "thrusshift_label";
            this.thrusshift_label.Size = new System.Drawing.Size(111, 20);
            this.thrusshift_label.TabIndex = 13;
            this.thrusshift_label.Text = "Thursday Shift";
            // 
            // Frishift_label
            // 
            this.Frishift_label.AutoSize = true;
            this.Frishift_label.Location = new System.Drawing.Point(205, 159);
            this.Frishift_label.Name = "Frishift_label";
            this.Frishift_label.Size = new System.Drawing.Size(89, 20);
            this.Frishift_label.TabIndex = 12;
            this.Frishift_label.Text = "Friday Shift";
            // 
            // Sunshift_label
            // 
            this.Sunshift_label.AutoSize = true;
            this.Sunshift_label.Location = new System.Drawing.Point(45, 104);
            this.Sunshift_label.Name = "Sunshift_label";
            this.Sunshift_label.Size = new System.Drawing.Size(100, 20);
            this.Sunshift_label.TabIndex = 11;
            this.Sunshift_label.Text = "Sunday Shift";
            // 
            // Satshift_label
            // 
            this.Satshift_label.AutoSize = true;
            this.Satshift_label.Location = new System.Drawing.Point(205, 212);
            this.Satshift_label.Name = "Satshift_label";
            this.Satshift_label.Size = new System.Drawing.Size(110, 20);
            this.Satshift_label.TabIndex = 10;
            this.Satshift_label.Text = "Saturday Shift";
            // 
            // Monshift_label
            // 
            this.Monshift_label.AutoSize = true;
            this.Monshift_label.Location = new System.Drawing.Point(45, 159);
            this.Monshift_label.Name = "Monshift_label";
            this.Monshift_label.Size = new System.Drawing.Size(102, 20);
            this.Monshift_label.TabIndex = 9;
            this.Monshift_label.Text = "Monday Shift";
            // 
            // ScheduleID_label
            // 
            this.ScheduleID_label.AutoSize = true;
            this.ScheduleID_label.Location = new System.Drawing.Point(45, 46);
            this.ScheduleID_label.Name = "ScheduleID_label";
            this.ScheduleID_label.Size = new System.Drawing.Size(93, 20);
            this.ScheduleID_label.TabIndex = 8;
            this.ScheduleID_label.Text = "ScheduleID";
            // 
            // Satshfit_input
            // 
            this.Satshfit_input.Location = new System.Drawing.Point(208, 235);
            this.Satshfit_input.Name = "Satshfit_input";
            this.Satshfit_input.Size = new System.Drawing.Size(100, 26);
            this.Satshfit_input.TabIndex = 7;
            // 
            // Frishift_input
            // 
            this.Frishift_input.Location = new System.Drawing.Point(208, 179);
            this.Frishift_input.Name = "Frishift_input";
            this.Frishift_input.Size = new System.Drawing.Size(100, 26);
            this.Frishift_input.TabIndex = 6;
            // 
            // Thursshift_input
            // 
            this.Thursshift_input.Location = new System.Drawing.Point(208, 127);
            this.Thursshift_input.Name = "Thursshift_input";
            this.Thursshift_input.Size = new System.Drawing.Size(100, 26);
            this.Thursshift_input.TabIndex = 5;
            // 
            // Wedshift_input
            // 
            this.Wedshift_input.Location = new System.Drawing.Point(208, 69);
            this.Wedshift_input.Name = "Wedshift_input";
            this.Wedshift_input.Size = new System.Drawing.Size(100, 26);
            this.Wedshift_input.TabIndex = 4;
            // 
            // Tuesshift_input
            // 
            this.Tuesshift_input.Location = new System.Drawing.Point(49, 235);
            this.Tuesshift_input.Name = "Tuesshift_input";
            this.Tuesshift_input.Size = new System.Drawing.Size(100, 26);
            this.Tuesshift_input.TabIndex = 3;
            // 
            // Monshift_input
            // 
            this.Monshift_input.Location = new System.Drawing.Point(49, 179);
            this.Monshift_input.Name = "Monshift_input";
            this.Monshift_input.Size = new System.Drawing.Size(100, 26);
            this.Monshift_input.TabIndex = 2;
            // 
            // Sunshift_input
            // 
            this.Sunshift_input.Location = new System.Drawing.Point(49, 127);
            this.Sunshift_input.Name = "Sunshift_input";
            this.Sunshift_input.Size = new System.Drawing.Size(100, 26);
            this.Sunshift_input.TabIndex = 1;
            // 
            // ScheduleID_input
            // 
            this.ScheduleID_input.Location = new System.Drawing.Point(49, 70);
            this.ScheduleID_input.Name = "ScheduleID_input";
            this.ScheduleID_input.Size = new System.Drawing.Size(100, 26);
            this.ScheduleID_input.TabIndex = 0;
            // 
            // guardSchedules_Dpanel
            // 
            this.guardSchedules_Dpanel.Location = new System.Drawing.Point(1394, 405);
            this.guardSchedules_Dpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guardSchedules_Dpanel.Name = "guardSchedules_Dpanel";
            this.guardSchedules_Dpanel.Size = new System.Drawing.Size(458, 329);
            this.guardSchedules_Dpanel.TabIndex = 16;
            // 
            // guardSchedules_IUpanel
            // 
            this.guardSchedules_IUpanel.Controls.Add(this.guardSchedule_Usubmitbutton);
            this.guardSchedules_IUpanel.Controls.Add(this.guardSchedule_scheduleID_input);
            this.guardSchedules_IUpanel.Controls.Add(this.guardSchedule_scheduleID_label);
            this.guardSchedules_IUpanel.Controls.Add(this.guardSchedule_Ulabel);
            this.guardSchedules_IUpanel.Location = new System.Drawing.Point(1394, 78);
            this.guardSchedules_IUpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guardSchedules_IUpanel.Name = "guardSchedules_IUpanel";
            this.guardSchedules_IUpanel.Size = new System.Drawing.Size(459, 291);
            this.guardSchedules_IUpanel.TabIndex = 15;
            // 
            // jobSchedules_Dpanel
            // 
            this.jobSchedules_Dpanel.Controls.Add(this.jobSchedule_Dsubmitbutton);
            this.jobSchedules_Dpanel.Controls.Add(this.jobSchedule_scheduleID_Dinput);
            this.jobSchedules_Dpanel.Controls.Add(this.jobSchedule_ScheduleID_Dlabel);
            this.jobSchedules_Dpanel.Controls.Add(this.jobSchedule_dlabel);
            this.jobSchedules_Dpanel.Location = new System.Drawing.Point(950, 405);
            this.jobSchedules_Dpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobSchedules_Dpanel.Name = "jobSchedules_Dpanel";
            this.jobSchedules_Dpanel.Size = new System.Drawing.Size(405, 329);
            this.jobSchedules_Dpanel.TabIndex = 14;
            // 
            // jobSchedule_Dsubmitbutton
            // 
            this.jobSchedule_Dsubmitbutton.Location = new System.Drawing.Point(184, 118);
            this.jobSchedule_Dsubmitbutton.Name = "jobSchedule_Dsubmitbutton";
            this.jobSchedule_Dsubmitbutton.Size = new System.Drawing.Size(85, 42);
            this.jobSchedule_Dsubmitbutton.TabIndex = 23;
            this.jobSchedule_Dsubmitbutton.Text = "Submit";
            this.jobSchedule_Dsubmitbutton.UseVisualStyleBackColor = true;
            // 
            // jobSchedule_scheduleID_Dinput
            // 
            this.jobSchedule_scheduleID_Dinput.Location = new System.Drawing.Point(41, 123);
            this.jobSchedule_scheduleID_Dinput.Name = "jobSchedule_scheduleID_Dinput";
            this.jobSchedule_scheduleID_Dinput.Size = new System.Drawing.Size(100, 26);
            this.jobSchedule_scheduleID_Dinput.TabIndex = 22;
            // 
            // jobSchedule_ScheduleID_Dlabel
            // 
            this.jobSchedule_ScheduleID_Dlabel.AutoSize = true;
            this.jobSchedule_ScheduleID_Dlabel.Location = new System.Drawing.Point(37, 88);
            this.jobSchedule_ScheduleID_Dlabel.Name = "jobSchedule_ScheduleID_Dlabel";
            this.jobSchedule_ScheduleID_Dlabel.Size = new System.Drawing.Size(93, 20);
            this.jobSchedule_ScheduleID_Dlabel.TabIndex = 21;
            this.jobSchedule_ScheduleID_Dlabel.Text = "ScheduleID";
            // 
            // jobSchedule_dlabel
            // 
            this.jobSchedule_dlabel.AutoSize = true;
            this.jobSchedule_dlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobSchedule_dlabel.Location = new System.Drawing.Point(36, 37);
            this.jobSchedule_dlabel.Name = "jobSchedule_dlabel";
            this.jobSchedule_dlabel.Size = new System.Drawing.Size(238, 29);
            this.jobSchedule_dlabel.TabIndex = 20;
            this.jobSchedule_dlabel.Text = "Delete Job Schedule";
            // 
            // jobSchedules_IUpanel
            // 
            this.jobSchedules_IUpanel.Controls.Add(this.jobSchedule_submitbutton);
            this.jobSchedules_IUpanel.Controls.Add(this.jobSchedules_ScheduleID_Iinput);
            this.jobSchedules_IUpanel.Controls.Add(this.jobSchedules_scheduleID_label);
            this.jobSchedules_IUpanel.Controls.Add(this.Jobschedules_Ilabel);
            this.jobSchedules_IUpanel.Location = new System.Drawing.Point(950, 78);
            this.jobSchedules_IUpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobSchedules_IUpanel.Name = "jobSchedules_IUpanel";
            this.jobSchedules_IUpanel.Size = new System.Drawing.Size(406, 291);
            this.jobSchedules_IUpanel.TabIndex = 13;
            // 
            // jobSchedule_submitbutton
            // 
            this.jobSchedule_submitbutton.Location = new System.Drawing.Point(184, 93);
            this.jobSchedule_submitbutton.Name = "jobSchedule_submitbutton";
            this.jobSchedule_submitbutton.Size = new System.Drawing.Size(85, 42);
            this.jobSchedule_submitbutton.TabIndex = 19;
            this.jobSchedule_submitbutton.Text = "Submit";
            this.jobSchedule_submitbutton.UseVisualStyleBackColor = true;
            // 
            // jobSchedules_ScheduleID_Iinput
            // 
            this.jobSchedules_ScheduleID_Iinput.Location = new System.Drawing.Point(41, 98);
            this.jobSchedules_ScheduleID_Iinput.Name = "jobSchedules_ScheduleID_Iinput";
            this.jobSchedules_ScheduleID_Iinput.Size = new System.Drawing.Size(100, 26);
            this.jobSchedules_ScheduleID_Iinput.TabIndex = 10;
            // 
            // jobSchedules_scheduleID_label
            // 
            this.jobSchedules_scheduleID_label.AutoSize = true;
            this.jobSchedules_scheduleID_label.Location = new System.Drawing.Point(37, 63);
            this.jobSchedules_scheduleID_label.Name = "jobSchedules_scheduleID_label";
            this.jobSchedules_scheduleID_label.Size = new System.Drawing.Size(93, 20);
            this.jobSchedules_scheduleID_label.TabIndex = 9;
            this.jobSchedules_scheduleID_label.Text = "ScheduleID";
            // 
            // Jobschedules_Ilabel
            // 
            this.Jobschedules_Ilabel.AutoSize = true;
            this.Jobschedules_Ilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jobschedules_Ilabel.Location = new System.Drawing.Point(36, 12);
            this.Jobschedules_Ilabel.Name = "Jobschedules_Ilabel";
            this.Jobschedules_Ilabel.Size = new System.Drawing.Size(210, 29);
            this.Jobschedules_Ilabel.TabIndex = 0;
            this.Jobschedules_Ilabel.Text = "Add Job Schedule";
            // 
            // guardSchedule_Usubmitbutton
            // 
            this.guardSchedule_Usubmitbutton.Location = new System.Drawing.Point(229, 93);
            this.guardSchedule_Usubmitbutton.Name = "guardSchedule_Usubmitbutton";
            this.guardSchedule_Usubmitbutton.Size = new System.Drawing.Size(85, 42);
            this.guardSchedule_Usubmitbutton.TabIndex = 27;
            this.guardSchedule_Usubmitbutton.Text = "Submit";
            this.guardSchedule_Usubmitbutton.UseVisualStyleBackColor = true;
            // 
            // guardSchedule_scheduleID_input
            // 
            this.guardSchedule_scheduleID_input.Location = new System.Drawing.Point(63, 98);
            this.guardSchedule_scheduleID_input.Name = "guardSchedule_scheduleID_input";
            this.guardSchedule_scheduleID_input.Size = new System.Drawing.Size(100, 26);
            this.guardSchedule_scheduleID_input.TabIndex = 26;
            // 
            // guardSchedule_scheduleID_label
            // 
            this.guardSchedule_scheduleID_label.AutoSize = true;
            this.guardSchedule_scheduleID_label.Location = new System.Drawing.Point(59, 63);
            this.guardSchedule_scheduleID_label.Name = "guardSchedule_scheduleID_label";
            this.guardSchedule_scheduleID_label.Size = new System.Drawing.Size(93, 20);
            this.guardSchedule_scheduleID_label.TabIndex = 25;
            this.guardSchedule_scheduleID_label.Text = "ScheduleID";
            // 
            // guardSchedule_Ulabel
            // 
            this.guardSchedule_Ulabel.AutoSize = true;
            this.guardSchedule_Ulabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardSchedule_Ulabel.Location = new System.Drawing.Point(47, 12);
            this.guardSchedule_Ulabel.Name = "guardSchedule_Ulabel";
            this.guardSchedule_Ulabel.Size = new System.Drawing.Size(271, 29);
            this.guardSchedule_Ulabel.TabIndex = 24;
            this.guardSchedule_Ulabel.Text = "Update Guard Schedule";
            // 
            // ScheduleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1876, 762);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScheduleEditor";
            this.Text = "ScheduleEditor";
            this.Load += new System.EventHandler(this.ScheduleEditor_Load);
            this.schedules_Dpanel.ResumeLayout(false);
            this.schedules_Dpanel.PerformLayout();
            this.schedules_IUpanel.ResumeLayout(false);
            this.schedules_IUpanel.PerformLayout();
            this.guardSchedules_IUpanel.ResumeLayout(false);
            this.guardSchedules_IUpanel.PerformLayout();
            this.jobSchedules_Dpanel.ResumeLayout(false);
            this.jobSchedules_Dpanel.PerformLayout();
            this.jobSchedules_IUpanel.ResumeLayout(false);
            this.jobSchedules_IUpanel.PerformLayout();
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
        private System.Windows.Forms.Label scheduleupdate_label;
        private System.Windows.Forms.Label scheduleadd_label;
        private System.Windows.Forms.Label Tuesshift_label;
        private System.Windows.Forms.Label wedshift_label;
        private System.Windows.Forms.Label thrusshift_label;
        private System.Windows.Forms.Label Frishift_label;
        private System.Windows.Forms.Label Sunshift_label;
        private System.Windows.Forms.Label Satshift_label;
        private System.Windows.Forms.Label Monshift_label;
        private System.Windows.Forms.Label ScheduleID_label;
        private System.Windows.Forms.TextBox Satshfit_input;
        private System.Windows.Forms.TextBox Frishift_input;
        private System.Windows.Forms.TextBox Thursshift_input;
        private System.Windows.Forms.TextBox Wedshift_input;
        private System.Windows.Forms.TextBox Tuesshift_input;
        private System.Windows.Forms.TextBox Monshift_input;
        private System.Windows.Forms.TextBox Sunshift_input;
        private System.Windows.Forms.TextBox ScheduleID_input;
        private System.Windows.Forms.Button Schedule_IUsubmitbutton;
        private System.Windows.Forms.Button Schedules_Dsubmitbutton;
        private System.Windows.Forms.TextBox Schedules_ScheduleID_Dinput;
        private System.Windows.Forms.Label Schedules_ScheduleID_Dinputlabel;
        private System.Windows.Forms.Label Schedules_Dlabel;
        private System.Windows.Forms.Label Jobschedules_Ilabel;
        private System.Windows.Forms.TextBox jobSchedules_ScheduleID_Iinput;
        private System.Windows.Forms.Label jobSchedules_scheduleID_label;
        private System.Windows.Forms.Button jobSchedule_Dsubmitbutton;
        private System.Windows.Forms.TextBox jobSchedule_scheduleID_Dinput;
        private System.Windows.Forms.Label jobSchedule_ScheduleID_Dlabel;
        private System.Windows.Forms.Label jobSchedule_dlabel;
        private System.Windows.Forms.Button jobSchedule_submitbutton;
        private System.Windows.Forms.Button guardSchedule_Usubmitbutton;
        private System.Windows.Forms.TextBox guardSchedule_scheduleID_input;
        private System.Windows.Forms.Label guardSchedule_scheduleID_label;
        private System.Windows.Forms.Label guardSchedule_Ulabel;
    }
}