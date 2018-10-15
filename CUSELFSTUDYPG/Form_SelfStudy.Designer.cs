namespace CUSELFSTUDYPG
{
    partial class Form_SelfStudy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SelfStudy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTomorrow = new System.Windows.Forms.Label();
            this.lbToday = new System.Windows.Forms.Label();
            this.lbYesterday = new System.Windows.Forms.Label();
            this.dgvTodayResult = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDay = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.lbCurrentSubject = new System.Windows.Forms.Label();
            this.lbCurrentDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.lbTitleDay = new System.Windows.Forms.Label();
            this.btnNewSchedule = new System.Windows.Forms.Button();
            this.menubar = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.alarm = new System.Windows.Forms.Timer(this.components);
            this.subjectTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayResult)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menubar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbTomorrow);
            this.panel1.Controls.Add(this.lbToday);
            this.panel1.Controls.Add(this.lbYesterday);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 624);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(7, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "selfstudy@gmail.com";
            // 
            // lbTomorrow
            // 
            this.lbTomorrow.BackColor = System.Drawing.Color.SlateGray;
            this.lbTomorrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTomorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTomorrow.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbTomorrow.Image = global::CUSELFSTUDYPG.Properties.Resources.icons8_alarm_clock_30;
            this.lbTomorrow.Location = new System.Drawing.Point(0, 216);
            this.lbTomorrow.Name = "lbTomorrow";
            this.lbTomorrow.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.lbTomorrow.Size = new System.Drawing.Size(227, 104);
            this.lbTomorrow.TabIndex = 2;
            this.lbTomorrow.Text = "Tomorrow";
            this.lbTomorrow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbTomorrow.Click += new System.EventHandler(this.lbTomorrow_Click);
            this.lbTomorrow.MouseLeave += new System.EventHandler(this.lbTomorrow_MouseLeave);
            this.lbTomorrow.MouseHover += new System.EventHandler(this.lbTomorrow_MouseHover);
            // 
            // lbToday
            // 
            this.lbToday.BackColor = System.Drawing.Color.SlateGray;
            this.lbToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToday.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbToday.Image = global::CUSELFSTUDYPG.Properties.Resources.icons8_alarm_clock_30;
            this.lbToday.Location = new System.Drawing.Point(0, 108);
            this.lbToday.Name = "lbToday";
            this.lbToday.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.lbToday.Size = new System.Drawing.Size(227, 108);
            this.lbToday.TabIndex = 1;
            this.lbToday.Text = "Today";
            this.lbToday.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbToday.Click += new System.EventHandler(this.lbToday_Click);
            this.lbToday.MouseLeave += new System.EventHandler(this.lbToday_MouseLeave);
            this.lbToday.MouseHover += new System.EventHandler(this.lbToday_MouseHover);
            // 
            // lbYesterday
            // 
            this.lbYesterday.BackColor = System.Drawing.Color.SlateGray;
            this.lbYesterday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbYesterday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYesterday.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbYesterday.Image = global::CUSELFSTUDYPG.Properties.Resources.icons8_alarm_clock_30;
            this.lbYesterday.Location = new System.Drawing.Point(0, 1);
            this.lbYesterday.Name = "lbYesterday";
            this.lbYesterday.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.lbYesterday.Size = new System.Drawing.Size(227, 107);
            this.lbYesterday.TabIndex = 0;
            this.lbYesterday.Text = "Yesterday";
            this.lbYesterday.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbYesterday.UseCompatibleTextRendering = true;
            this.lbYesterday.Click += new System.EventHandler(this.lbYesterday_Click);
            this.lbYesterday.MouseLeave += new System.EventHandler(this.lbYesterday_MouseLeave);
            this.lbYesterday.MouseHover += new System.EventHandler(this.lbYesterday_MouseHover);
            // 
            // dgvTodayResult
            // 
            this.dgvTodayResult.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvTodayResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodayResult.Location = new System.Drawing.Point(9, 168);
            this.dgvTodayResult.Name = "dgvTodayResult";
            this.dgvTodayResult.RowTemplate.Height = 28;
            this.dgvTodayResult.Size = new System.Drawing.Size(987, 367);
            this.dgvTodayResult.TabIndex = 2;
            this.dgvTodayResult.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTodayResult_CellMouseClick);
            this.dgvTodayResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTodayResult_MouseDoubleClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.btnStop);
            this.panel4.Controls.Add(this.btnTimer);
            this.panel4.Controls.Add(this.lbCurrentSubject);
            this.panel4.Controls.Add(this.lbCurrentDate);
            this.panel4.Controls.Add(this.dgvTodayResult);
            this.panel4.ForeColor = System.Drawing.Color.DarkBlue;
            this.panel4.Location = new System.Drawing.Point(227, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 624);
            this.panel4.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(822, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.lbDay);
            this.panel3.Controls.Add(this.lbTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 582);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 42);
            this.panel3.TabIndex = 11;
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbDay.Location = new System.Drawing.Point(400, 6);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(60, 30);
            this.lbDay.TabIndex = 5;
            this.lbDay.Text = "Day";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lbTime.Location = new System.Drawing.Point(774, 3);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(78, 34);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "Time";
            this.lbTime.Click += new System.EventHandler(this.lbTime_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(650, 95);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(124, 45);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop Music";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnTimer.Location = new System.Drawing.Point(822, 95);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(166, 45);
            this.btnTimer.TabIndex = 9;
            this.btnTimer.Text = "No Alarm";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // lbCurrentSubject
            // 
            this.lbCurrentSubject.AutoSize = true;
            this.lbCurrentSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentSubject.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbCurrentSubject.Location = new System.Drawing.Point(9, 108);
            this.lbCurrentSubject.Name = "lbCurrentSubject";
            this.lbCurrentSubject.Size = new System.Drawing.Size(174, 32);
            this.lbCurrentSubject.TabIndex = 8;
            this.lbCurrentSubject.Text = "Now Subject";
            // 
            // lbCurrentDate
            // 
            this.lbCurrentDate.AutoSize = true;
            this.lbCurrentDate.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentDate.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbCurrentDate.Location = new System.Drawing.Point(261, 25);
            this.lbCurrentDate.Name = "lbCurrentDate";
            this.lbCurrentDate.Size = new System.Drawing.Size(212, 38);
            this.lbCurrentDate.TabIndex = 7;
            this.lbCurrentDate.Text = "Current Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.title);
            this.panel2.ForeColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 85);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CUSELFSTUDYPG.Properties.Resources.if_gear_star_532769;
            this.pictureBox1.Location = new System.Drawing.Point(11, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 49);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FloralWhite;
            this.title.Location = new System.Drawing.Point(61, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(166, 38);
            this.title.TabIndex = 0;
            this.title.Text = "Self Study";
            // 
            // lbTitleDay
            // 
            this.lbTitleDay.AutoSize = true;
            this.lbTitleDay.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lbTitleDay.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleDay.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbTitleDay.Location = new System.Drawing.Point(566, 23);
            this.lbTitleDay.Name = "lbTitleDay";
            this.lbTitleDay.Size = new System.Drawing.Size(301, 43);
            this.lbTitleDay.TabIndex = 3;
            this.lbTitleDay.Text = "Today Schedule";
            // 
            // btnNewSchedule
            // 
            this.btnNewSchedule.BackColor = System.Drawing.Color.DarkGray;
            this.btnNewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSchedule.ForeColor = System.Drawing.Color.Snow;
            this.btnNewSchedule.Location = new System.Drawing.Point(246, 19);
            this.btnNewSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewSchedule.Name = "btnNewSchedule";
            this.btnNewSchedule.Size = new System.Drawing.Size(123, 54);
            this.btnNewSchedule.TabIndex = 4;
            this.btnNewSchedule.Text = "New";
            this.btnNewSchedule.UseVisualStyleBackColor = false;
            this.btnNewSchedule.Click += new System.EventHandler(this.btnNewSchedule_Click);
            // 
            // menubar
            // 
            this.menubar.BackColor = System.Drawing.Color.SlateGray;
            this.menubar.Controls.Add(this.pbClose);
            this.menubar.Controls.Add(this.btnNewSchedule);
            this.menubar.Controls.Add(this.lbTitleDay);
            this.menubar.Controls.Add(this.panel2);
            this.menubar.Dock = System.Windows.Forms.DockStyle.Top;
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(1235, 86);
            this.menubar.TabIndex = 0;
            this.menubar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menubar_MouseDown);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::CUSELFSTUDYPG.Properties.Resources.icons8_cancel_48;
            this.pbClose.Location = new System.Drawing.Point(1156, 7);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(79, 74);
            this.pbClose.TabIndex = 5;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // alarm
            // 
            this.alarm.Tick += new System.EventHandler(this.alarm_Tick);
            // 
            // subjectTimer
            // 
            this.subjectTimer.Tick += new System.EventHandler(this.subjectTimer_Tick);
            // 
            // Form_SelfStudy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1235, 710);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menubar);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SelfStudy";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Self Study";
            this.Load += new System.EventHandler(this.Form_SelfStudy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayResult)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTodayResult;
        private System.Windows.Forms.Label lbYesterday;
        private System.Windows.Forms.Label lbTomorrow;
        private System.Windows.Forms.Label lbToday;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lbTitleDay;
        private System.Windows.Forms.Button btnNewSchedule;
        private System.Windows.Forms.Panel menubar;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCurrentDate;
        private System.Windows.Forms.Label lbCurrentSubject;
        private System.Windows.Forms.Timer alarm;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer subjectTimer;



    }
}

