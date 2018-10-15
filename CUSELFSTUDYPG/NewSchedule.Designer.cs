namespace CUSELFSTUDYPG
{
    partial class NewSchedule
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpST = new System.Windows.Forms.DateTimePicker();
            this.dtpET = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvReview = new System.Windows.Forms.DataGridView();
            this.lbResult = new System.Windows.Forms.Label();
            this.lberror = new System.Windows.Forms.Label();
            this.newScheduleHeader = new System.Windows.Forms.Panel();
            this.pbCloseNewSchedule = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).BeginInit();
            this.newScheduleHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseNewSchedule)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.dtpDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dtpDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDate.Location = new System.Drawing.Point(375, 24);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(430, 37);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(141, 30);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(345, 26);
            this.txtSubject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(773, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 39);
            this.label6.TabIndex = 2;
            this.label6.Text = "To";
            // 
            // dtpST
            // 
            this.dtpST.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpST.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpST.Location = new System.Drawing.Point(592, 106);
            this.dtpST.Name = "dtpST";
            this.dtpST.ShowUpDown = true;
            this.dtpST.Size = new System.Drawing.Size(170, 37);
            this.dtpST.TabIndex = 7;
            this.dtpST.ValueChanged += new System.EventHandler(this.dtpST_ValueChanged);
            // 
            // dtpET
            // 
            this.dtpET.CausesValidation = false;
            this.dtpET.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpET.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpET.Location = new System.Drawing.Point(830, 109);
            this.dtpET.Name = "dtpET";
            this.dtpET.ShowUpDown = true;
            this.dtpET.Size = new System.Drawing.Size(174, 37);
            this.dtpET.TabIndex = 8;
            this.dtpET.ValueChanged += new System.EventHandler(this.dtpET_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.Location = new System.Drawing.Point(801, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(205, 48);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add To Table";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvReview
            // 
            this.dgvReview.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReview.Location = new System.Drawing.Point(20, 255);
            this.dgvReview.Name = "dgvReview";
            this.dgvReview.RowTemplate.Height = 28;
            this.dgvReview.Size = new System.Drawing.Size(989, 289);
            this.dgvReview.TabIndex = 10;
            this.dgvReview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvReview_MouseDoubleClick);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbResult.Location = new System.Drawing.Point(14, 116);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(251, 34);
            this.lbResult.TabIndex = 11;
            this.lbResult.Text = "Review Schedule";
            // 
            // lberror
            // 
            this.lberror.AutoSize = true;
            this.lberror.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberror.ForeColor = System.Drawing.Color.Crimson;
            this.lberror.Location = new System.Drawing.Point(142, 77);
            this.lberror.Name = "lberror";
            this.lberror.Size = new System.Drawing.Size(99, 22);
            this.lberror.TabIndex = 12;
            this.lberror.Text = "Error show";
            // 
            // newScheduleHeader
            // 
            this.newScheduleHeader.BackColor = System.Drawing.Color.DarkBlue;
            this.newScheduleHeader.Controls.Add(this.pbCloseNewSchedule);
            this.newScheduleHeader.Controls.Add(this.label1);
            this.newScheduleHeader.Controls.Add(this.dtpDate);
            this.newScheduleHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.newScheduleHeader.Location = new System.Drawing.Point(0, 0);
            this.newScheduleHeader.Name = "newScheduleHeader";
            this.newScheduleHeader.Size = new System.Drawing.Size(1026, 87);
            this.newScheduleHeader.TabIndex = 13;
            this.newScheduleHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newScheduleHeader_MouseDown);
            // 
            // pbCloseNewSchedule
            // 
            this.pbCloseNewSchedule.Image = global::CUSELFSTUDYPG.Properties.Resources.icons8_cancel_48;
            this.pbCloseNewSchedule.Location = new System.Drawing.Point(933, 3);
            this.pbCloseNewSchedule.Name = "pbCloseNewSchedule";
            this.pbCloseNewSchedule.Size = new System.Drawing.Size(77, 84);
            this.pbCloseNewSchedule.TabIndex = 13;
            this.pbCloseNewSchedule.TabStop = false;
            this.pbCloseNewSchedule.Click += new System.EventHandler(this.pbCloseNewSchedule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 43);
            this.label1.TabIndex = 12;
            this.label1.Text = "Review Schedule";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lberror);
            this.panel1.Controls.Add(this.txtSubject);
            this.panel1.Controls.Add(this.lbResult);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 482);
            this.panel1.TabIndex = 14;
            // 
            // NewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1026, 569);
            this.Controls.Add(this.dgvReview);
            this.Controls.Add(this.dtpET);
            this.Controls.Add(this.dtpST);
            this.Controls.Add(this.newScheduleHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Schedule Information";
            this.Load += new System.EventHandler(this.NewSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).EndInit();
            this.newScheduleHeader.ResumeLayout(false);
            this.newScheduleHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseNewSchedule)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpST;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvReview;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.DateTimePicker dtpET;
        private System.Windows.Forms.Label lberror;
        private System.Windows.Forms.Panel newScheduleHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbCloseNewSchedule;
    }
}